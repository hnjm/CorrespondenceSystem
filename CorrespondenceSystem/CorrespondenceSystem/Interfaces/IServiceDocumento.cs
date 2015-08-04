﻿using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceDocumento
    {
        List<Documento> GetAllDocumentos();
        List<Documento> GetAllDocumentosByStatus(string status);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal);
        List<Documento> GetAllDocumentosByTipoDepartamento(int idTipoDepartamento);
        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        void InsertDocumento(Documento documento);
        void UpdateDocumento(Documento documento);
        void UpdateStatus(Documento documento);
    }
}