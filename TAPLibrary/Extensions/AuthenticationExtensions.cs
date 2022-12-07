using System.Collections.Generic;
using System.Linq;

using TAPLibrary.ViewModels;

namespace TAPLibrary.Extensions {
    public static class AuthenticationExtensions {

        public static IEnumerable<UserViewModel> WithoutPasswords( this IEnumerable<UserViewModel> users ) {
            return users.Select( x => x.WithoutPassword() );
        }

        public static UserViewModel WithoutPassword( this UserViewModel user ) {
            user.Password = null;
            return user;
        }
    
    }
}
