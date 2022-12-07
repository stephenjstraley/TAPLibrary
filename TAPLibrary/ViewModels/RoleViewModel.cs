using System.Collections.Generic;

namespace TAPLibrary.ViewModels {
    public class RoleViewModel {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<ClaimViewModel> Claims { get; set; } = new List<ClaimViewModel>();
    }
}
