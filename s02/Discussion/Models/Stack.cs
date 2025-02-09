using System.ComponentModel.DataAnnotations;

namespace Discussion.Models
{
    public enum Stack
    {
        MEAN,
        MERN,
        Django,
        [Display(Name ="Ruby on Rails")]Rails,
        LAMP
    }
}
