# Hotel System (merged project)

All pages are now in ONE project and linked together.

Open `HotelSystem.csproj` in Visual Studio 2022 (needs the .NET 8 SDK), then Start.

## Login accounts (temporary, in Core/UserStore.cs)
| Role         | Username  | Password     |
|--------------|-----------|--------------|
| Admin        | admin     | admin123     |
| Receptionist | reception | reception123 |

On the login page pick ADMIN or RECEPTIONIST, then enter that account's username/password.

## Permissions (Core/Session.cs -> CanAccess)
| Page                  | Admin | Receptionist |
|-----------------------|:-----:|:------------:|
| Dashboard             |  yes  |     yes      |
| Customers             |  yes  |     yes      |
| Reservations          |  yes  |     yes      |
| Payments              |  yes  |     yes      |
| Rooms                 |  yes  |     no       |
| Reports & Statistics  |  yes  |     no       |

Pages the receptionist cannot open appear greyed out in the sidebar, and are also blocked in code.

## Where things are
- `Core/Nav.cs`       open pages + wires the sidebar buttons/logout of every form (one `Nav.Wire(this)` line per form)
- `Core/Session.cs`   current user/role + permissions
- `Core/UserStore.cs` username/password list (replace with a database later)
- `Forms/*`           the 7 pages: Login, Dashboard, Rooms, Customers, Reservations, Payments, Reports
