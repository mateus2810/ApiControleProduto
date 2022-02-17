using ControleProduto.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProdutoApi.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.IdProduto);
            builder.Property(p => p.NomeProduto).IsRequired(false).HasMaxLength(20);
            builder.Property(p => p.Preco).IsRequired(false);
            builder.Property(p => p.PrecoPromocao).IsRequired(false);
            builder.Property(p => p.QuantidadeEstoque).IsRequired(false);

            builder.HasData(
                new Produto
                {
                    IdProduto = 1,
                    NomeProduto = "nome do produto",
                    Preco = 15,
                    PrecoPromocao = 10,
                    QuantidadeEstoque = 100

                });

            builder.ToTable("Produto");
        }
    }
}
