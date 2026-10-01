using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

// ============================================================================
// CATÁLOGO CENTRAL DE 10 POLOS EN MEMORIA (STOCK TOTAL: 223 UNIDADES)
// Sincronizado con las URLs de imágenes actualizadas desde el Dashboard CRUD
// ============================================================================
var polos = new List<PoloItem>
{
    // ==========================================
    // 1. POLOS COLOR: NEGRO (#111111)
    // ==========================================
    new PoloItem
    {
        Id = 1,
        Codigo = "POL-001",
        Nombre = "Tribio Heavyweight Oversized Tee Black",
        Categoria = "Polos",
        Subcategoria = "Oversize",
        Genero = "Unisex",
        Talla = "S, M, L, XL",
        Color = "Negro",
        ColorHex = "#111111",
        Precio = 139.90,
        Stock = 35,
        Marca = "Tribio",
        Material = "Algodón Peruano 280 GSM",
        Temporada = "Todo el año",
        Descuento = 15,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-1),
        Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY6OaHkKoroztqpuqslJpL8TJsiNO9rMavgD5D23KaEsR4slSKsKP_b7o&s=10",
        Descripcion = "Polo corte oversize confeccionado en algodón tangüis pesado de 280 GSM con hombros caídos y cuello acanalado reforzado."
    },
    new PoloItem
    {
        Id = 2,
        Codigo = "POL-002",
        Nombre = "Nike Sportswear Premium Boxy Tee",
        Categoria = "Polos",
        Subcategoria = "Boxy Fit",
        Genero = "Hombre",
        Talla = "M, L, XL",
        Color = "Negro",
        ColorHex = "#111111",
        Precio = 159.00,
        Stock = 22,
        Marca = "Nike",
        Material = "Algodón Peinado 260 GSM",
        Temporada = "Todo el año",
        Descuento = 10,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-2),
        Imagen = "https://www.thecultperu.com.pe/cdn/shop/files/207338-1200-auto.jpg?v=1785959703&width=533",
        Descripcion = "Silueta cuadrada Boxy Fit con bordado minimalista en el pecho y caída estructurada."
    },

    // ==========================================
    // 2. POLOS COLOR: BLANCO (#FFFFFF)
    // ==========================================
    new PoloItem
    {
        Id = 4,
        Codigo = "POL-004",
        Nombre = "Tribio Essential Clean White Tee",
        Categoria = "Polos",
        Subcategoria = "Básico",
        Genero = "Unisex",
        Talla = "XS, S, M, L, XL",
        Color = "Blanco",
        ColorHex = "#FFFFFF",
        Precio = 119.00,
        Stock = 40,
        Marca = "Tribio",
        Material = "Algodón Pima Peruano 240 GSM",
        Temporada = "Todo el año",
        Descuento = 10,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddHours(-12),
        Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtMBOu9jcR1u-Mm3uHY6l5ozg6l0eFewgZ3mKrYYhL5Q&s=10",
        Descripcion = "Polo blanco esencial de tacto frío en algodón Pima peruano, ideal para outfits limpios y uso diario."
    },
    new PoloItem
    {
        Id = 5,
        Codigo = "POL-005",
        Nombre = "Jordan Flight Heritage Oversized White",
        Categoria = "Polos",
        Subcategoria = "Gráfico",
        Genero = "Hombre",
        Talla = "M, L, XL",
        Color = "Blanco",
        ColorHex = "#FFFFFF",
        Precio = 169.90,
        Stock = 15,
        Marca = "Jordan",
        Material = "Algodón 100% Estructurado",
        Temporada = "Verano",
        Descuento = 15,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-3),
        Imagen = "https://i.ebayimg.com/images/g/1-cAAOSwaONnxTO3/s-l1200.webp",
        Descripcion = "Edición inspirada en la cultura sneaker con gráfico Flight de archivo y ajuste holgado."
    },

    // ==========================================
    // 3. POLOS COLOR: BEIGE / CREMA (#D6C7B2)
    // ==========================================
    new PoloItem
    {
        Id = 7,
        Codigo = "POL-007",
        Nombre = "Essentials Fear Of Style Sand Beige Tee",
        Categoria = "Polos",
        Subcategoria = "Oversize",
        Genero = "Unisex",
        Talla = "S, M, L, XL",
        Color = "Beige",
        ColorHex = "#D6C7B2",
        Precio = 145.00,
        Stock = 24,
        Marca = "Essentials",
        Material = "Algodón Peinado 280 GSM",
        Temporada = "Todo el año",
        Descuento = 10,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddHours(-6),
        Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTY7d9P9YvFRW3FAHp-bNipiyPq1LBBtcjaSOQsAcQhtA&s=10",
        Descripcion = "Tono arena minimalista con hombros ultra caídos y etiqueta engomada en la espalda superior."
    },
    new PoloItem
    {
        Id = 8,
        Codigo = "POL-008",
        Nombre = "Tribio Desert Dune Boxy Tee",
        Categoria = "Polos",
        Subcategoria = "Boxy Fit",
        Genero = "Unisex",
        Talla = "S, M, L",
        Color = "Beige",
        ColorHex = "#D6C7B2",
        Precio = 129.90,
        Stock = 19,
        Marca = "Tribio",
        Material = "Algodón Tangüis 260 GSM",
        Temporada = "Verano",
        Descuento = 5,
        EsNuevo = false,
        FechaCreacion = DateTime.UtcNow.AddDays(-8),
        Imagen = "https://www.manelsanchez.com/uploads/media/images/800x800/adidas-essentials-logo-boxy-t-shirt-white-13.jpg.webp",
        Descripcion = "Color crema natural teñido con pigmentos orgánicos y corte cuadrado perfecto."
    },

    // ==========================================
    // 4. POLOS COLOR: GRIS / CARBÓN (#52525B)
    // ==========================================
    new PoloItem
    {
        Id = 9,
        Codigo = "POL-009",
        Nombre = "Tribio Acid Wash Charcoal Graphic Tee",
        Categoria = "Polos",
        Subcategoria = "Gráfico",
        Genero = "Unisex",
        Talla = "S, M, L, XL",
        Color = "Gris",
        ColorHex = "#52525B",
        Precio = 155.00,
        Stock = 17,
        Marca = "Tribio",
        Material = "Algodón Lavado Ácido 280 GSM",
        Temporada = "Otoño",
        Descuento = 20,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-1),
        Imagen = "https://www.catlifestyle.pe/media/catalog/product/p/o/polos-hombre-caterpillar-cat-logo-pique-4010329-10122_1_jqmllckv2w4oalci.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=550&width=550&canvas=550:550",
        Descripcion = "Acabado gris carbón vintage lavado al ácido con serigrafía trasera de colección."
    },

    // ==========================================
    // 5. POLOS COLOR: VERDE (#166534)
    // ==========================================
    new PoloItem
    {
        Id = 11,
        Codigo = "POL-011",
        Nombre = "Tribio Forest Olive Oversized Tee",
        Categoria = "Polos",
        Subcategoria = "Oversize",
        Genero = "Unisex",
        Talla = "S, M, L, XL",
        Color = "Verde",
        ColorHex = "#166534",
        Precio = 139.90,
        Stock = 21,
        Marca = "Tribio",
        Material = "Algodón Peruano 280 GSM",
        Temporada = "Todo el año",
        Descuento = 12,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-2),
        Imagen = "https://www.migamarra.pe/cdn/shop/files/skeep_fotos_tamano_app_2.025_ff917409-568b-4601-81ff-50716f81ad55.jpg?v=1752437397&width=1445",
        Descripcion = "Tono verde bosque profundo de estética cargo streetwear con costuras visibles."
    },

    // ==========================================
    // 6. POLOS COLOR: ROJO (#DC2626)
    // ==========================================
    new PoloItem
    {
        Id = 12,
        Codigo = "POL-012",
        Nombre = "Jordan Chicago Bulls Gym Red Tee",
        Categoria = "Polos",
        Subcategoria = "Gráfico",
        Genero = "Hombre",
        Talla = "S, M, L, XL",
        Color = "Rojo",
        ColorHex = "#DC2626",
        Precio = 165.00,
        Stock = 14,
        Marca = "Jordan",
        Material = "Algodón 260 GSM",
        Temporada = "Verano",
        Descuento = 15,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-4),
        Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcNFqHNI0R5BHxwNEizogLM62TiSmiChxaswj18Wzin10h4t73l4AxSlQ&s=10",
        Descripcion = "Rojo intenso inspirado en la herencia Chicago con estampado frontal de alto contraste."
    },

    // ==========================================
    // 7. POLOS COLOR: AZUL (#1D4ED8)
    // ==========================================
    new PoloItem
    {
        Id = 13,
        Codigo = "POL-013",
        Nombre = "Adidas Originals Cobalt Longsleeve Polo",
        Categoria = "Polos",
        Subcategoria = "Manga Larga",
        Genero = "Unisex",
        Talla = "M, L, XL",
        Color = "Azul",
        ColorHex = "#1D4ED8",
        Precio = 175.00,
        Stock = 16,
        Marca = "Adidas",
        Material = "Algodón Piqué 280 GSM",
        Temporada = "Invierno",
        Descuento = 10,
        EsNuevo = true,
        FechaCreacion = DateTime.UtcNow.AddDays(-3),
        Imagen = "https://http2.mlstatic.com/D_NQ_NP_652074-MPE108572375763_032026-O.webp",
        Descripcion = "Polo manga larga en azul cobalto con puños acanalados y tres tiras clásicas en mangas."
    }
};

static string ResolverColorHex(string? color, string? hexActual)
{
    var c = (color ?? "").Trim().ToLowerInvariant();
    if (c.Contains("negro") || c.Contains("black")) return "#111111";
    if (c.Contains("blanco") || c.Contains("white")) return "#FFFFFF";
    if (c.Contains("beige") || c.Contains("crema") || c.Contains("arena") || c.Contains("sand")) return "#D6C7B2";
    if (c.Contains("gris") || c.Contains("carbon") || c.Contains("carbón") || c.Contains("grey") || c.Contains("charcoal")) return "#52525B";
    if (c.Contains("verde") || c.Contains("green") || c.Contains("olive")) return "#166534";
    if (c.Contains("rojo") || c.Contains("red")) return "#DC2626";
    if (c.Contains("azul") || c.Contains("blue") || c.Contains("navy")) return "#1D4ED8";

    if (!string.IsNullOrWhiteSpace(hexActual) && hexActual.StartsWith("#"))
        return hexActual;

    return "#18181B";
}

app.MapGet("/", () => "API TribioShop - Catálogo de Polos & CRUD funcionando correctamente");

Func<string?, string?, string?, string?, string?, string?, IResult> filtrarPolosHandler =
    (string? color, string? marca, string? subcategoria, string? talla, string? orden, string? buscar) =>
{
    IEnumerable<PoloItem> query = polos;

    if (!string.IsNullOrWhiteSpace(color) && !color.Equals("Todos", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(p => p.Color.Contains(color.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    if (!string.IsNullOrWhiteSpace(marca) && !marca.Equals("Todas", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(p => p.Marca.Equals(marca.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    if (!string.IsNullOrWhiteSpace(subcategoria) && !subcategoria.Equals("Todos", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(p => p.Subcategoria.Contains(subcategoria.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    if (!string.IsNullOrWhiteSpace(talla) && !talla.Equals("Todas", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(p =>
            p.Talla.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                   .Any(t => t.Equals(talla.Trim(), StringComparison.OrdinalIgnoreCase)));
    }

    if (!string.IsNullOrWhiteSpace(buscar))
    {
        var q = buscar.Trim();
        query = query.Where(p =>
            p.Nombre.Contains(q, StringComparison.OrdinalIgnoreCase) ||
            p.Codigo.Contains(q, StringComparison.OrdinalIgnoreCase) ||
            p.Marca.Contains(q, StringComparison.OrdinalIgnoreCase) ||
            p.Color.Contains(q, StringComparison.OrdinalIgnoreCase) ||
            p.Subcategoria.Contains(q, StringComparison.OrdinalIgnoreCase));
    }

    query = (orden ?? "recientes").ToLowerInvariant() switch
    {
        "precio_asc" or "precio-asc" => query.OrderBy(p => p.Precio * (1 - p.Descuento / 100.0)),
        "precio_desc" or "precio-desc" => query.OrderByDescending(p => p.Precio * (1 - p.Descuento / 100.0)),
        "descuento" or "ofertas" => query.OrderByDescending(p => p.Descuento).ThenByDescending(p => p.FechaCreacion),
        _ => query.OrderByDescending(p => p.FechaCreacion).ThenByDescending(p => p.Id)
    };

    return Results.Ok(query.ToList());
};

app.MapGet("/api/ropa", filtrarPolosHandler);
app.MapGet("/api/ropa/polos", filtrarPolosHandler);

app.MapGet("/api/ropa/filtros", () =>
{
    var colores = polos
        .GroupBy(p => p.Color)
        .Select(g => new { color = g.Key, colorHex = g.First().ColorHex, total = g.Count() })
        .ToList();

    var marcas = polos
        .GroupBy(p => p.Marca)
        .Select(g => new { marca = g.Key, total = g.Count() })
        .ToList();

    var subcategorias = polos
        .GroupBy(p => p.Subcategoria)
        .Select(g => new { subcategoria = g.Key, total = g.Count() })
        .ToList();

    return Results.Ok(new
    {
        totalPolos = polos.Count,
        colores,
        marcas,
        subcategorias
    });
});

app.MapGet("/api/ropa/{id:int}", (int id) =>
{
    var item = polos.FirstOrDefault(p => p.Id == id);
    return item is not null
        ? Results.Ok(item)
        : Results.NotFound(new { message = $"No se encontró el polo con ID {id}" });
});

app.MapPost("/api/ropa", ([FromBody] PoloItem nuevo) =>
{
    var nextId = polos.Count > 0 ? polos.Max(p => p.Id) + 1 : 1;
    nuevo.Id = nextId;
    nuevo.Codigo = string.IsNullOrWhiteSpace(nuevo.Codigo) ? $"POL-{nextId:D3}" : nuevo.Codigo.Trim();
    nuevo.Categoria = string.IsNullOrWhiteSpace(nuevo.Categoria) ? "Polos" : nuevo.Categoria.Trim();
    nuevo.Subcategoria = string.IsNullOrWhiteSpace(nuevo.Subcategoria) ? "Oversize" : nuevo.Subcategoria.Trim();
    nuevo.Genero = string.IsNullOrWhiteSpace(nuevo.Genero) ? "Unisex" : nuevo.Genero.Trim();
    nuevo.Talla = string.IsNullOrWhiteSpace(nuevo.Talla) ? "S, M, L, XL" : nuevo.Talla.Trim();
    nuevo.Color = string.IsNullOrWhiteSpace(nuevo.Color) ? "Negro" : nuevo.Color.Trim();
    nuevo.ColorHex = ResolverColorHex(nuevo.Color, nuevo.ColorHex);
    nuevo.Marca = string.IsNullOrWhiteSpace(nuevo.Marca) ? "Tribio" : nuevo.Marca.Trim();
    nuevo.Material = string.IsNullOrWhiteSpace(nuevo.Material) ? "Algodón Peruano 260 GSM" : nuevo.Material.Trim();
    nuevo.Temporada = string.IsNullOrWhiteSpace(nuevo.Temporada) ? "Todo el año" : nuevo.Temporada.Trim();
    nuevo.EsNuevo = true;
    nuevo.FechaCreacion = DateTime.UtcNow;

    polos.Insert(0, nuevo);
    return Results.Created($"/api/ropa/{nuevo.Id}", nuevo);
});

app.MapPut("/api/ropa/{id:int}", (int id, [FromBody] PoloItem actualizado) =>
{
    var existente = polos.FirstOrDefault(p => p.Id == id);
    if (existente is null)
    {
        return Results.NotFound(new { message = $"No se encontró el polo con ID {id}" });
    }

    existente.Codigo = string.IsNullOrWhiteSpace(actualizado.Codigo) ? existente.Codigo : actualizado.Codigo.Trim();
    existente.Nombre = string.IsNullOrWhiteSpace(actualizado.Nombre) ? existente.Nombre : actualizado.Nombre.Trim();
    existente.Categoria = string.IsNullOrWhiteSpace(actualizado.Categoria) ? "Polos" : actualizado.Categoria.Trim();
    existente.Subcategoria = string.IsNullOrWhiteSpace(actualizado.Subcategoria) ? existente.Subcategoria : actualizado.Subcategoria.Trim();
    existente.Genero = string.IsNullOrWhiteSpace(actualizado.Genero) ? existente.Genero : actualizado.Genero.Trim();
    existente.Talla = string.IsNullOrWhiteSpace(actualizado.Talla) ? existente.Talla : actualizado.Talla.Trim();
    existente.Color = string.IsNullOrWhiteSpace(actualizado.Color) ? existente.Color : actualizado.Color.Trim();
    existente.ColorHex = ResolverColorHex(existente.Color, actualizado.ColorHex);
    existente.Precio = actualizado.Precio;
    existente.Stock = actualizado.Stock;
    existente.Marca = string.IsNullOrWhiteSpace(actualizado.Marca) ? existente.Marca : actualizado.Marca.Trim();
    existente.Material = string.IsNullOrWhiteSpace(actualizado.Material) ? existente.Material : actualizado.Material.Trim();
    existente.Temporada = string.IsNullOrWhiteSpace(actualizado.Temporada) ? existente.Temporada : actualizado.Temporada.Trim();
    existente.Descuento = actualizado.Descuento;
    existente.Imagen = string.IsNullOrWhiteSpace(actualizado.Imagen) ? existente.Imagen : actualizado.Imagen.Trim();
    existente.Descripcion = actualizado.Descripcion ?? existente.Descripcion;

    return Results.Ok(existente);
});

app.MapDelete("/api/ropa/{id:int}", (int id) =>
{
    var existente = polos.FirstOrDefault(p => p.Id == id);
    if (existente is null)
    {
        return Results.NotFound(new { message = $"No se encontró el polo con ID {id}" });
    }

    polos.Remove(existente);
    return Results.NoContent();
});

var port = Environment.GetEnvironmentVariable("PORT") ?? Environment.GetEnvironmentVariable("Port") ?? "10000";
app.Run($"http://0.0.0.0:{port}");

public class PoloItem
{
    public int Id { get; set; }
    public string Codigo { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Categoria { get; set; } = "Polos";
    public string Subcategoria { get; set; } = "Oversize";
    public string Genero { get; set; } = "Unisex";
    public string Talla { get; set; } = "S, M, L, XL";
    public string Color { get; set; } = "Negro";
    public string ColorHex { get; set; } = "";
    public double Precio { get; set; }
    public int Stock { get; set; }
    public string Marca { get; set; } = "Tribio";
    public string Material { get; set; } = "Algodón Peruano";
    public string Temporada { get; set; } = "Todo el año";
    public int Descuento { get; set; }
    public bool EsNuevo { get; set; } = true;
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public string Imagen { get; set; } = "";
    public string Descripcion { get; set; } = "";
}
