using System.ComponentModel.DataAnnotations;

using Fantasy.Shared.Resources;

namespace Fantasy.Shared.DTOs;

public class JoinGroupDTO
{
    [Display(Name = "Code", ResourceType = typeof(Literals))]
    [MaxLength(6, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Code { get; set; } = null!;

    public string? UserName { get; set; }
}