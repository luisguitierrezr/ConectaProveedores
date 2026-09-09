using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name"},
{"paymentdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate"},
{"proposaldate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate"},
{"proposaltypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid"},
{"bankid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid"},
{"proposalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid"},
{"fileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid"},
{"totalproposallines", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines"},
{"totalvalueml", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml"},
{"totalvaluemd", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"lastupdatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon"},
{"maxdatepaymentchanges", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges"},
{"assignedtoid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, "propo_u8aqr95gpfe0_5vh5m3v1_13"));
}
} // ENProposalEntity

}

