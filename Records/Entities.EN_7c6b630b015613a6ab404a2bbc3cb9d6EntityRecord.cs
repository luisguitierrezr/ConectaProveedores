using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalLineEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalLineEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id"},
{"proposalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"companyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"fe_contab_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_"},
{"ej__mes", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes"},
{"cuenta", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta"},
{"referencia", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia"},
{"nombre1", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1"},
{"nombre2", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2"},
{"n_doc_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_"},
{"n_doctype", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype"},
{"importeenml", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml"},
{"ml", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml"},
{"importeenmd", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd"},
{"mon_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_"},
{"soc_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_"},
{"div_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_"},
{"lib_mayor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor"},
{"textocab_documento", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento"},
{"doc_comp_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_"},
{"paidby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby"},
{"paidon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon"},
{"unpaidby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby"},
{"unpaidon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon"},
{"haserrors", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors"},
{"errormessage", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, "propo_u8aqr95gpfexlw3amx2kzh66"));
}
} // ENProposalLineEntity

}

