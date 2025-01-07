using System;
namespace Desafio4
{
    public interface IGerente
    {
        void Autorizar();
        bool ConcedeAumentoEmpregado(Empregado empregado);
        bool ConcedeAumentoVendedor(Vendedor vendedor);
        void VerStatusLicenca(Empregado empregado);
        bool AutorizarLicenca(Empregado empregado);

    }
}