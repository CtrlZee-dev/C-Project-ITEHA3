# C-Project-ITEHA3

Here's a concise README template for your GitHub repository that highlights key aspects of your project:

---

# SA Online Mart

**SA Online Mart** is an e-commerce platform developed using C# and ASP.NET Core. The project allows users to browse, search, and purchase South African products, offering a seamless shopping experience with features like user authentication, product management, and order processing.

## Features

- **User Authentication**: Secure login and registration for Customers and Admins using ASP.NET Core Identity.
- **Product Management**: Admins can add, edit, and delete products through a dedicated admin panel.
- **Shopping Cart**: Users can add products to their cart, view details, and proceed to checkout.
- **Order Management**: View and manage orders, track status updates, and process payments.
- **Category Navigation**: Browse products by categories such as Dresses, Tops, Bottoms, and more.

## Technologies Used

- **Frontend**: Razor Pages, HTML, CSS, JavaScript, Bootstrap
- **Backend**: ASP.NET Core, C#, Entity Framework Core
- **Database**: SQL Server
- **APIs**: Custom-built Web API for product, category, and order management

## Getting Started

### Prerequisites

- **.NET 6.0 SDK** or later
- **SQL Server** (or any compatible SQL database)
- **Visual Studio** (recommended) or any other IDE supporting .NET development

### Installation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/SA-Online-Mart.git
   ```
2. **Navigate to the Project Directory:**
   ```bash
   cd SA-Online-Mart
   ```
3. **Set Up the Database:**
   - Update the connection string in `appsettings.json` to match your SQL Server setup.
   - Run database migrations:
     ```bash
     dotnet ef database update
     ```

4. **Run the Application:**
   ```bash
   dotnet run
   ```

### Usage

- **Admin Panel**: Access the admin panel to manage products, categories, and orders.
- **User Dashboard**: Customers can view their profile, order history, and manage cart items.



---

Feel free to adjust any specific sections, such as the installation steps or project description, to better fit your actual setup and goals!
