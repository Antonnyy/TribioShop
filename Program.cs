var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(policy =>
            {
                policy
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            }
        );
    }
);

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API ropa funcionando";
});

app.MapGet("/api/ropa", () =>
{
    return Results.Ok(new[]
    {
        new {
            id = 1,
            codigo = "POL-001",
            nombre = "Tribio Heavyweight Oversized Tee",
            categoria = "Polos",
            genero = "Unisex",
            talla = "L",
            color = "Washed Black",
            precio = 149.90,
            stock = 35,
            marca = "Tribio",
            material = "Algodón Peruano 280 GSM",
            temporada = "Atemporal",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=800&auto=format&fit=crop&q=80",
            descripcion = "Polo corte boxy confeccionado con 100% algodón tangüis pesado de 280 GSM. Caída estructurada y cuello acanalado de 3cm."
        },
        new {
            id = 2,
            codigo = "HOD-002",
            nombre = "Tribio Heritage Streetwear Fleece Hoodie",
            categoria = "Hoodies",
            genero = "Unisex",
            talla = "M",
            color = "Anthracite Dark",
            precio = 349.90,
            stock = 19,
            marca = "Tribio",
            material = "Algodón 82% Fleece 380 GSM + 18% Poliéster",
            temporada = "Invierno 2026",
            descuento = 20,
            imagen = "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=800&auto=format&fit=crop&q=80",
            descripcion = "Polera con capucha forrada, bolsillo frontal canguro y hombros caídos de corte relajado."
        },
        new {
            id = 3,
            codigo = "CRG-003",
            nombre = "Tribio Tactical Multi-Pocket Cargo Pants",
            categoria = "Pantalones",
            genero = "Unisex",
            talla = "32",
            color = "Deep Slate Khaki",
            precio = 219.90,
            stock = 16,
            marca = "Tribio",
            material = "Tejido Ripstop Resistente 100% Algodón",
            temporada = "Atemporal",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1624378439575-d8705ad7ae80?w=800&auto=format&fit=crop&q=80",
            descripcion = "Pantalón cargo de 6 bolsillos utilitarios con cinturón de ajuste integrado y puños ceñibles."
        },
        new {
            id = 4,
            codigo = "CAS-004",
            nombre = "Karl Kani Retro Puffer Down Jacket",
            categoria = "Casacas",
            genero = "Unisex",
            talla = "XL",
            color = "Glossy Black",
            precio = 529.00,
            stock = 9,
            marca = "Karl Kani",
            material = "Exterior repelente al agua + Relleno térmico de fibra ecológica",
            temporada = "Otoño-Invierno",
            descuento = 25,
            imagen = "https://images.unsplash.com/photo-1544022613-e87ca75a784a?w=800&auto=format&fit=crop&q=80",
            descripcion = "La casaca puffer definitiva de inspiración hip-hop vintage. Cuello alto acolchado y bordado frontal distintivo."
        },
        new {
            id = 5,
            codigo = "SNK-005",
            nombre = "Air Force 1 '07 Triple White",
            categoria = "Zapatillas",
            genero = "Unisex",
            talla = "41",
            color = "Triple White",
            precio = 479.90,
            stock = 25,
            marca = "Nike",
            material = "Cuero Genuino",
            temporada = "Atemporal",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=800&auto=format&fit=crop&q=80",
            descripcion = "La silueta clásica de la cultura sneaker con amortiguación Air encapsulada."
        },
        new {
            id = 6,
            codigo = "SNK-006",
            nombre = "Air Jordan 4 Retro \"Toro Bravo\"",
            categoria = "Zapatillas",
            genero = "Hombre",
            talla = "42",
            color = "Gym Red / Black",
            precio = 839.90,
            stock = 12,
            marca = "Jordan",
            material = "Nubuck Premium",
            temporada = "Edición Limitada",
            descuento = 33,
            imagen = "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=800&auto=format&fit=crop&q=80",
            descripcion = "Clásico de culto de 1989 reeditado con capellada completa en gamuza nubuck roja fuego."
        },
        new {
            id = 7,
            codigo = "POL-007",
            nombre = "Polo Oversize Streetwear Beige",
            categoria = "Polos",
            genero = "Unisex",
            talla = "M",
            color = "Sand Beige",
            precio = 89.90,
            stock = 17,
            marca = "Tribio",
            material = "100% Algodón Peinado 240 GSM",
            temporada = "Verano",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&auto=format&fit=crop&q=80",
            descripcion = "Polo oversize urbano conectado al catálogo de la API. Confeccionado en algodón suave con hombros caídos."
        },
        new {
            id = 8,
            codigo = "HOD-008",
            nombre = "PSG Tracksuit Warm-Up Essential",
            categoria = "Hoodies",
            genero = "Hombre",
            talla = "L",
            color = "Navy / Red",
            precio = 319.90,
            stock = 8,
            marca = "Nike",
            material = "Poliéster Dri-FIT",
            temporada = "Temporada 2026",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1578632767115-351597cf2477?w=800&auto=format&fit=crop&q=80",
            descripcion = "Conjunto oficial de calentamiento deportivo con tecnología transpirable Dri-FIT y escudo termotransferido."
        }
    });
});

var port = Environment.GetEnvironmentVariable("Port") ?? "10000";
app.Run($"http://0.0.0.0:{port}");