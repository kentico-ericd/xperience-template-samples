using System;

namespace BlankCore.AdvancedTemplate
{
    public class CustomServiceForMessages
    {
        public string GetMessageFromExternalAPI()
        {
            return $"The letter of the day is {Guid.NewGuid()}";
        }
    }
}
