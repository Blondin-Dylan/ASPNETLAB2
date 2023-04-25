using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rp_ef_maria.Models;


public class SiteUser
{

    public uint SiteUserId { get; set; }
    public string UserName { get; set; } = "";
}
