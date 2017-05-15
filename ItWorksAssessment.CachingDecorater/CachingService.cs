using ItWorksAssessment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItWorksAssessment.CachingDecorater
{
    public class CachingService : IItWorksAssessmentService
    {
        //hardcoded to 10 s but could be retrieved from configuration in production
        private TimeSpan _cacheDuration = TimeSpan.FromSeconds(30);
        private DateTime _dataDateTime;
        private IItWorksAssessmentService _itWorksAssessmentService;
        private int[] _cachedItems;


        private bool IsCacheValid
        {
            get
            {
                var _cacheAge = DateTimeOffset.Now - _dataDateTime;
                return _cacheAge < _cacheDuration;
            }
        }
        private void ValidateCache(int n)
        {
            if (_cachedItems == null || !IsCacheValid)
            {
                try
                {
                    _cachedItems = _itWorksAssessmentService.PrintNumbers(n);
                    _dataDateTime = DateTime.Now;
                }
                catch
                {
                    //returning a default array to catch errors
                    _cachedItems = new List<int>().ToArray();
                }
            }
        }
        private void InvalidateCache()
        {
            _cachedItems = null;
        }
        public CachingService(IItWorksAssessmentService itWorksAssessmentService)
        {
            _itWorksAssessmentService = itWorksAssessmentService;
        }
        public int[] PrintNumbers(int number)
        {
            ValidateCache(number);
            return _cachedItems;
        }
    }

}
