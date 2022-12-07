import { type } from "os";

export type registeredUsers = {
  Id: number;
  email: string;
  password: string;
  firstName: string;
  lastName: string;
  photo: string;
  roles: string;
};

//  public Guid Id { get; set; } //PK
//         [Required(ErrorMessage ="Email is required")]
//         public string Email { get; set; }
//         [Required (ErrorMessage ="Password is required.")]
//         public string Password { get; set; }
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public string Avatar { get; set; }
//         public ICollection<string> Roles { get; set; }
//         public DateTime CreatedDate { get; set; }
