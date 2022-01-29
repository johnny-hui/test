using System.ComponentModel.DataAnnotations;

namespace lab4.Models;
public class Province {
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }
    public List<City>? Cities { get; set; }
}
