namespace ProductSample;

/// <summary>
/// 产品类
/// </summary>
internal class Product
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException("名称不能为空");
            }
            _name = value;
        }
    }

    private string _category;
    public string Category
    {
        get => _category;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException("类别不能为空");
            }
            _category = value;
        }
    }
    public string Description { get; set; }

    private decimal _price;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value <= 0)
            {
                throw new InvalidOperationException("价格不能小于或等于0");
            }
            _price = value;
        }
    }

    private int _stock;
    public int Stock
    {
        get => _stock;
        set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("库存不能小于0");
            }
            _stock = value;
        }
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="name">商品名称</param>
    /// <param name="category">类别</param>
    /// <param name="description">描述</param>
    /// <param name="price">单价</param>
    /// <param name="stock">库存</param>
    public Product(string name, string category, string description, decimal price, int stock)
    {
        Name = name;
        Category = category;
        Description = description;
        Price = price;
        Stock = stock;
    }

    public void Sell(int count)
    {
        if (count <= 0)
        {
            throw new InvalidOperationException("销售数量不能小于或等于0");
        }
        if (Stock < count)
        {
            throw new InvalidOperationException("库存不足");
        }
        Stock -= count;
        Console.WriteLine($"成功售出 {count} 个{Name}，库存剩余 {Stock} 个");
    }

    public void Restock(int count)
    {
        if (count <= 0)
        {
            throw new InvalidOperationException("进货数量不能小于或等于0");
        }

        Stock += count;
        Console.WriteLine($"成功进货 {count} 个{Name}，库存剩余 {Stock} 个");
    }

    public override string ToString()
    {
        return $"{Name}（{Category}）, {Description}, 单价: {Price:C}, 库存: {Stock}";
    }
}
