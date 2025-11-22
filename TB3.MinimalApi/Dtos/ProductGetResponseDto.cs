namespace TB3.MinimalApi.Dtos;

public class ProductCreateRequestDto
{
    public string ProductName { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}

public class ProductUpdateRequestDto
{
    public string ProductName { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}

public class ProductPatchRequestDto
{
    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }
}

public class ProductGetResponseDto
{
    public string ProductName { get; set; }
}

public class ProductGetListResponseDto
{

}
