namespace ImproveAbilityInSqlAndC_.Domain.Consts.Product
{
    public class ProductQueries
    {
        public static string getAllProducts => @"Select * from soradb..Products";

        public static string getMoreExpensiveProductByCategory = @"
                ;WITH MaxProductByCategory AS 
				(
					SELECT 
						P.id,
						P.category,
						P.name,
						P.description,
						P.price,
						P.createAt,
						ROW_NUMBER() OVER (PARTITION BY P.category ORDER BY P.price DESC) AS rn
					FROM soradb..Products P 
				)
				SELECT 
					MPBC.id,
					MPBC.category,
					MPBC.name,
					MPBC.description,
					MPBC.price,
					MPBC.createAt
				FROM MaxProductByCategory MPBC
				WHERE MPBC.rn = 1
				ORDER BY MPBC.id";
    }
}
