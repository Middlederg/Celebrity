using System;
using System.ComponentModel.DataAnnotations;

namespace Celebrity.Shared
{
    public class ConfirmEmailModel
    {
        public Guid? UserId { get; set; }
        public string Code { get; set; }
    }
}
