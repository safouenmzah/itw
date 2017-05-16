var DocumentTypeEnum = {
    SlowDocument: 1,
    StandardDocument: 2,
    QuickDocument: 3
}
var hideDocumentDetails = function () {
    $("#quickDocumentDetails").addClass("hidden");
    $("#standardDocumentDetails").addClass("hidden");
    $("#slowDocumentDetails").addClass("hidden");
}
var showDocumentDetails = function (documentTypeEnum) {
    switch (documentTypeEnum) {
        case DocumentTypeEnum.QuickDocument:
            $("#quickDocumentDetails").removeClass("hidden");
            $("#standardDocumentDetails").addClass("hidden");
            $("#slowDocumentDetails").addClass("hidden");
            break;

        case DocumentTypeEnum.StandardDocument:
            $("#standardDocumentDetails").removeClass("hidden");
            $("#quickDocumentDetails").addClass("hidden");
            $("#slowDocumentDetails").addClass("hidden");
            break;

        case DocumentTypeEnum.SlowDocument:
            $("#slowDocumentDetails").removeClass("hidden");
            $("#standardDocumentDetails").addClass("hidden");
            $("#quickDocumentDetails").addClass("hidden");
            break;

        default:
            hideDocumentDetails();
            break;
    }
}

var ajaxPostJson = function (method, jsonIn, callback) {
    return $.ajax({
        url: '/Home/' + method,
        type: "POST",
        data: JSON.stringify(jsonIn),
        dataType: "html",
        contentType: "application/json",
        success: function (json) {
            callback(json);
        }
    });
}

var ajaxPostJsonWithDelay = function (method, jsonIn, callback) {

    var delay = (jsonIn.delay !== "-1" ? Number(jsonIn.delay, 10) : 0) * 1000; 

    return $.ajax({
        url: '/Home/' + method,
        type: "POST",
        data: JSON.stringify(jsonIn),
        dataType: "html",
        contentType: "application/json",
        success: function (json) {
            setTimeout(callback(json), delay)            
        }
    });
}

var DocumentVm = function () {
    self = this;
    self.name = "";
    self.content = "";
    self.type = 0;
    self.numberOfCopies = 0;
    self.delay = 0;
};

var postDocumentDetailsCallBack = function (response) {
    $("#printout").html(response);
}

var postDocumentDetails = function (callback, document) {
    return ajaxPostJson("Print", document, callback);
};


var postQuickDocumentDetailsCallBack = function (response) {
    $("#printout").html(response);
}

var postStandardDocumentDetailsCallBack = function (response) {   
    $("#printout").append(response);
}

var postSlowDocumentDetailsCallBack = function (response) {
    $("#printout").append(response);
}





var postQuickDocumentDetails = function (callback, document) {
    return ajaxPostJson("Print", document, callback);
};

var postStandardDocumentDetails = function (callback, document) {
    return ajaxPostJson("Print", document, callback);
};

var postSlowDocumentDetails = function (callback, document) {    
    return  ajaxPostJsonWithDelay("Print", document, callback);
};

$(function () {
    $("#documentTypeSelect").on("change", function () {
        var self = this;
        var selectedDocumentType = Number($(self).val(), 10);

        //$(this).closest('form').find("input[type=text], textarea, select").val("");
        $("#printout").html("");
        

        switch (selectedDocumentType) {
            case DocumentTypeEnum.QuickDocument:
                showDocumentDetails(3);
                break;
            case DocumentTypeEnum.StandardDocument:
                showDocumentDetails(2);
                break;
            case DocumentTypeEnum.SlowDocument:
                showDocumentDetails(1);
                break;

            default:
                hideDocumentDetails();
                break;
        }

    });

   

    $("#printBtn").on("click", function (e) {
        e.preventDefault();

        var documentType = Number($("#documentTypeSelect").val(), 10);
      

        switch (documentType) {
            case DocumentTypeEnum.SlowDocument:
                var vm = new DocumentVm();
                vm.name = ($("#slowDocumentName").val());
                vm.content = ($("#slowDocumentContent").val());
                vm.numberOfCopies = ($("#slowDocumentNumberOfCopiesSelect").val());
                vm.delay = ($("#slowDocumentPrintDelaySelect").val());
                vm.documentType = documentType;

                for (var i = 1; i <= vm.numberOfCopies; i++) {                    
                    postSlowDocumentDetails(postSlowDocumentDetailsCallBack, vm);
                }
                
                break;

            case DocumentTypeEnum.QuickDocument:
                var vm = new DocumentVm();
                vm.name = ($("#quickDocumentName").val());
                vm.content = ($("#quickDocumentContent").val());
                vm.documentType = documentType;

                postQuickDocumentDetails(postQuickDocumentDetailsCallBack, vm);
                break;

            case DocumentTypeEnum.StandardDocument:
                var vm = new DocumentVm();
                vm.name = ($("#standardDocumentName").val());
                vm.content = ($("#standardDocumentContent").val());
                vm.numberOfCopies = ($("#standardDocumentNumberOfCopiesSelect").val())
                vm.documentType = documentType;

                for (var i = 1; i <= vm.numberOfCopies; i++) {
                    postStandardDocumentDetails(postStandardDocumentDetailsCallBack, vm);
                }
               
                break;
        }



    });


    $("#resetBtn").click(function () {
        //$(this).closest('form').find("input[type=text], textarea, select").val("");
        location.reload();
    });
})