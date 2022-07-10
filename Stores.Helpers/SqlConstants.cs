namespace Stores.Helpers
{
    public class SqlConstants
    {
       public static readonly string BrandListQuery = "SELECT *FROM Brand WHERE IsDeleted = 0";
       public static readonly string BrandListQueryById = "SELECT *FROM Brand WHERE BrandId = @id AND IsDeleted = 0";

        public static readonly string CategoriesListQuery = "SELECT *FROM Categories WHERE IsDeleted = 0";
        public static readonly string AddCategoriesQuery = "INSERT INTO Categories(CategoryName,CreatedBy)VALUES(@categoryNamem,@createdBy)";
        public static readonly string UpdateCategoriesQuery = "UPDATE Categories SET Category = @categoryName,ModifiedBy=@modifiedBy WHERE CategoryId=@categoryId,CategoryName=@categoryName)";
        public static readonly string CategoriesListQueryById = "SELECT *FROM Categories WHERE CategoyId = @id AND IsDeleted = 0";
        public static readonly string DeleteCategoriesQuery = "DELETE FRODM Categories WHERE CategoryId=@id";
        public static readonly string JobStatusListQuery = "SELECT *FROM JobStatus WHERE IsDeleted=0";
        public static readonly string DeleteJobStatusQuery = "DELETE FROM JobStatus WHERE StatusId=@id";
        public static readonly string AddJobStatusQuery = "INSERT INTO JobStatus(StatusName,CreatedBy)VALUES(@statusName ,@createdBy)";
        public static readonly string JobStatusListQueryById = "SELECT *FROM JobStatus WHERE JobStatusId=@id AND IsDeleted =0";
        public static readonly string UpdateJobStatusQuery = "UPDATE JobStatus SET statusName = @statusName,ModifiedBy=@modifiedBy WHERE StatusId=@statusId,StatusName=@statusName)";
        public static readonly string ProductListQuery = "SELECT *FROM Product WHERE IsDeleted=0";
        public static readonly string ProductListQueryById = "SELECT *FROM Product WHERE ProductId=@id AND IsDeleted = 0";
        public static readonly string AddProductQuery = "INSERT INTO Product(ProductName,Model,Price,ProductReleaseDate,CreatedBy)VALUES(@productName,@model,@price,@productreleasedate,@createdby)";
        public static readonly string UpdateProductQuery = "UPDATE Product SET Product =@productName,Model=@model,Price=@price,ProductReleaseDate=@productreleasedate,ModifiedBy=@modifiedBy WHERE ProductId=@productId,Product=@productName,Model=@model,Price=@price,ProductReleaseDate=@productreleasedate";
        public static readonly string DeleteProductQuery = "DELETE FROM Product WHERE ProductId=@id";
        public static readonly string RolesListQuery = "SELECT *FROM Roles WHERE IsDeleted=0";
        public static readonly string RolesListQueryById = "SELECT *FROM Roles WHERE RolesId = @id AND IsDeleted = 0";
        public static readonly string AddRolesQuery = "INSERT INTO ROLES(RoleName,CreatedBy)VALUES(@roleName,@createdBy)";
        public static readonly string UpdateRolesQuery = "UPDATE Roles SET Roles = @roleName,ModifiedBy=@modifiedBy WHERE RoleId=@rolesId,RoleName=@roleName)";
        public static readonly string DeleteRolesQuery = "DELETE FROM Roles WHERE RoleId=@id";
        public static readonly string ServiceListListQuery = "SELECT*FROM ServiceList WHERE IsDeleted=0";
        public static readonly string UpdateServiceListQuery = "UPDATE ServiceList SET CustomerName = @customerName,ModifiedBy=@modifiedBy WHERE ServiceListId=@servicelistId,CustomerName=@cutomerName";       
        public static readonly string ServiceListListQueryById = "SELECT *FROM ServiceList WHERE ServiceListId=@id AND IsDeleted=0";
        public static readonly string DeleteServiceListQuery = "DELETE FROM ServiceList WHERE ServiceListId=@id";
        public static readonly string AddServiceListQuery = "INSERT INTO ServiceList(CustomeName,Model,JobCardStatus,Description,ServiceAllocatedTo,DateofPurchase,JobCardNumber,PhoneNumber,CreatedBy)VALUES(@customerName,@model,@jobcardstatus,@description,@serviceallocatedto,@dateofpurchase,@jobcardnumber,@phonenumber,@createdBy)";
        public static readonly string UserDetailsListQuery = "SELECT*FROM UserDetails WHERE IsDeleted=0";
        public static readonly string UserDetailsListQueryById = "SELECT *FROM UserDetails WHERE UserId =@id AND IsDeleted = 0 ";
        public static readonly string UpdateUserDetailsQuery = "UPDATE UserDetails SET UserName=@userName,ModifiedBy=@modifiedBy WHERE UserId=@userId,UserName=@userName)";
        public static readonly string DeleteUserDetailsQuery = "DELETE FROM UserDetails WHERE UserI =@id";
        public static readonly string AddUserDetailsQuery = "INSERT INTO UserDetails(UserName,FirstName,LastName,MobileNo,@CreatedBy)VALUES(@userName,@firstName,@lastName,@mobileNo,@createdBy)";
        public static readonly string AddBrandQuery = "INSERT INTO Brand(BrandName,CreatedBy)VALUES(@brandName,@createdBy)";
        public static readonly string UpdateBrandQuery = "UPDATE Brand SET BrandName = @brandName,ModifiedBy=@modifiedBy WHERE BrandId=@brandId)";
        public static readonly string DeleteBrandQuery = "DELETE FROM Brand WHERE BrandId =@id";


    }
}