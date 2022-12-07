import { useState } from "react";
import config from "../config";
import { registeredUsers } from "../types/registeredUsers";

const UsersList = () => {

    const [users, setUsers] = useState<registeredUsers[]>([]);
    const fetchUserDetails = async () => {
        const response = await fetch(`${config.baseApiUrl}/users`);
        const users = await response.json();
        setUsers(users);
    };
    fetchUserDetails();
    return (
        <div>
            <div className="row mb-2">
                <h5 className="themeFontColor text-center">
                    All users
                </h5>
            </div>
            <table className="table table-hover">
                <thead>
                    <tr>
                        <td>First Name</td>
                        <td>Last Name</td>
                        <td>Email</td>
                    </tr>
                </thead>
                <tbody>
                    {users.map((u) => (
                        <tr key={u.Id}>
                            <td>{u.firstName}</td>
                            <td>{u.lastName}</td>
                            <td>{ u.email}</td>

                        </tr>
                    ))}
                </tbody>

            </table>
        </div>
    )
}

export default UsersList;