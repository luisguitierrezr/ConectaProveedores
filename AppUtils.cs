using OutSystems.Application.ManifestGeneration;

namespace ssConectaProveedores;

public sealed class AppUtils : BaseAppUtils {
    // Entity functions (<Entity>.LocalViewName, <Entity>.AttributeDatabaseName) by entity name.
    private static Dictionary<string, Tuple<Func<string, string>, Func<string, string>>> entityFunctions;

    public static readonly AppUtils Instance = new();

    public override string GetOwnerUrlPath() {
        return "/ConectaProveedores/";
    }

    protected override string EntityToTablename(string entity) {
        string entityLC = entity.ToLowerInvariant();

        var entityFuncs = GetEntityFunctions(entityLC);

        if (entityFuncs != null) {
            return entityFuncs.Item1(BuiltInFunction.GetCurrentLocale()); // Item1 is LocalViewName method.
        }

        throw DatabaseErrorsHelper.UnknownEntity(entity);
    }

    protected override string EntityAttributeToColumnName(string entityName, string attributeName) {
        string entityNameLC = entityName.ToLowerInvariant();
        string columnName = null;

        var entityFuncs = GetEntityFunctions(entityNameLC);

        if (entityFuncs != null) {
            columnName = entityFuncs.Item2(attributeName); // Item2 is AttributeDatabaseName method.
        }

        if (string.IsNullOrEmpty(columnName)) {
            throw DatabaseErrorsHelper.UnknownAttribute(attributeName, entityName);
        }

        return columnName;
    }

    public string RuntimeEntityReplace(string entity) {
        return EntityToTablename(entity);
    }

    private static readonly Regex LinkRegex = new(@"@(?:\.?\w)+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    public string RuntimeEntityReplaceLinkTable(string resolvedTableName, string attr) {
        if (!string.IsNullOrEmpty(attr)) {
            var linkMatch = LinkRegex.Match(resolvedTableName);
            if ((linkMatch != null) && linkMatch.Success) {
                string linkPart = linkMatch.Value;
                resolvedTableName = resolvedTableName.Remove(resolvedTableName.Length - linkPart.Length, linkPart.Length);
                return resolvedTableName + attr + linkPart;
            }
        }
        return resolvedTableName + attr;
    }

    public void RuntimeCheckReadOnlyEntity(string[] entitiesToCheck) {
        foreach (string entity in entitiesToCheck) {
            if (CheckReadOnlyInvalidOperations(entity)) {
                throw DatabaseErrorsHelper.EntityReadOnly(entity);
            }
        }
    }

    protected override bool CheckReadOnlyInvalidOperations(string entity) {
        string entityLC = entity.ToLowerInvariant();
if (entityLC == "orderstatus")
    return true;
if (entityLC == "foliostatus")
    return true;
if (entityLC == "orderretentiontype")
    return true;
if (entityLC == "contractfiletype")
    return true;
if (entityLC == "invoicestatus")
    return true;
if (entityLC == "proposaltype")
    return true;
if (entityLC == "ordermainitemstatus")
    return true;
if (entityLC == "commenttype")
    return true;
if (entityLC == "approvalstatus")
    return true;
if (entityLC == "invoicetaxtype")
    return true;
if (entityLC == "contractstatus")
    return true;
if (entityLC == "logsaccountingsubject")
    return true;
if (entityLC == "proposalstatus")
    return true;
if (entityLC == "invoiceaccountingprocessstatus")
    return true;
if (entityLC == "requisitionstatus")
    return true;
if (entityLC == "specialapproval")
    return true;
if (entityLC == "importstatus")
    return true;
if (entityLC == "approvalprocesslevel")
    return true;
if (entityLC == "approvalprocess")
    return true;
if (entityLC == "specialworkflowuploadpuestos")
    return true;
if (entityLC == "processtype")
    return true;
if (entityLC == "specialworkflows")
    return true;
if (entityLC == "approvalprocessmatrix")
    return true;
if (entityLC == "seriestype")
    return true;
if (entityLC == "legendposition")
    return true;
if (entityLC == "legendlayout")
    return true;
if (entityLC == "operator")
    return true;
if (entityLC == "currency")
    return true;
if (entityLC == "dayofweek")
    return true;
if (entityLC == "bank")
    return true;
if (entityLC == "processstatus")
    return true;
if (entityLC == "activitystatus")
    return true;
if (entityLC == "user")
    return true;
if (entityLC == "activitykind")
    return true;
if (entityLC == "marginsize")
    return true;
if (entityLC == "papersize")
    return true;
if (entityLC == "audit")
    return true;
if (entityLC == "origin")
    return true;
if (entityLC == "sidemenubehavior")
    return true;
if (entityLC == "size")
    return true;
if (entityLC == "guttersize")
    return true;
if (entityLC == "orientation")
    return true;
if (entityLC == "datepickertimeformat")
    return true;
if (entityLC == "accordionicontype")
    return true;
if (entityLC == "direction")
    return true;
if (entityLC == "breakcolumns")
    return true;
if (entityLC == "shape")
    return true;
if (entityLC == "position")
    return true;
if (entityLC == "trigger")
    return true;
if (entityLC == "space")
    return true;
if (entityLC == "booleantypes")
    return true;
if (entityLC == "accordioniconposition")
    return true;
if (entityLC == "scrollbarstyle")
    return true;
if (entityLC == "color")
    return true;
if (entityLC == "steps")
    return true;
if (entityLC == "videostate")
    return true;
if (entityLC == "datepickerweekday")
    return true;
if (entityLC == "roleconcept")
    return true;
if (entityLC == "userapplicationrole")
    return true;
if (entityLC == "concept")
    return true;
if (entityLC == "applicationrole")
    return true;
if (entityLC == "userapplicationroletempbyconcept")
    return true;
if (entityLC == "entrarole")
    return true;
if (entityLC == "userapplicationroletemp")
    return true;
if (entityLC == "rolestatus")
    return true;
if (entityLC == "userextension")
    return true;
if (entityLC == "deletedstorage")
    return true;
if (entityLC == "internalconcept")
    return true;
if (entityLC == "storage")
    return true;
if (entityLC == "accountingaccounts_servicetype")
    return true;
if (entityLC == "deposittype")
    return true;
if (entityLC == "accountingdatatype")
    return true;
if (entityLC == "insurancetype")
    return true;
if (entityLC == "manuals")
    return true;
if (entityLC == "paymentoptions")
    return true;
if (entityLC == "manualfile")
    return true;
if (entityLC == "customsettings")
    return true;
if (entityLC == "serviceformat")
    return true;
if (entityLC == "invoiceusage")
    return true;
if (entityLC == "subdirection")
    return true;
if (entityLC == "applicanttelceldirection")
    return true;
if (entityLC == "cfditype")
    return true;
if (entityLC == "purchasinggroup")
    return true;
if (entityLC == "taxindicator")
    return true;
if (entityLC == "distribution")
    return true;
if (entityLC == "retentiontypes")
    return true;
if (entityLC == "user_extended_internal")
    return true;
if (entityLC == "ivaexceptionm9suppliers")
    return true;
if (entityLC == "user_preferences")
    return true;
if (entityLC == "documenttype")
    return true;
if (entityLC == "supplieruser")
    return true;
if (entityLC == "company")
    return true;
if (entityLC == "department")
    return true;
if (entityLC == "applicant")
    return true;
if (entityLC == "approvalprocesstype")
    return true;
if (entityLC == "supplier")
    return true;
if (entityLC == "costcentersap")
    return true;
if (entityLC == "accountableguide")
    return true;
if (entityLC == "customsettingtype")
    return true;
if (entityLC == "specialpostdeliveryauthorization")
    return true;
if (entityLC == "telceldirection")
    return true;
if (entityLC == "frequency")
    return true;
if (entityLC == "management")
    return true;
if (entityLC == "segmentaccgroup")
    return true;
if (entityLC == "appconcept")
    return true;
if (entityLC == "invoicesusageaccounts")
    return true;
if (entityLC == "customsettingvalue")
    return true;
if (entityLC == "entryblockdates")
    return true;
if (entityLC == "project_asset_service")
    return true;
if (entityLC == "manualuserarea")
    return true;
if (entityLC == "paymentterms")
    return true;
if (entityLC == "paymentways")
    return true;
if (entityLC == "userarea")
    return true;
if (entityLC == "advancepaymenttype")
    return true;
if (entityLC == "paymentmethods")
    return true;
if (entityLC == "segmentaccgrouptelceldir")
    return true;
if (entityLC == "supplierdetail")
    return true;
if (entityLC == "fiscalyearexceptions")
    return true;
if (entityLC == "businessvaluecategory")
    return true;
if (entityLC == "sustainability")
    return true;
if (entityLC == "virtualstore")
    return true;
if (entityLC == "region")
    return true;
if (entityLC == "processtypedatesallowed")
    return true;
if (entityLC == "businessvaluesubcategory")
    return true;
if (entityLC == "entradomain")
    return true;
if (entityLC == "aicontenttype")
    return true;
if (entityLC == "airole")
    return true;

        return false;
    }

    public static ObjectKey eSpaceId {
        get {
            return eSpaceKey;
        }
    }

    public static ObjectKey eSpaceKey {
        get {
            return StaticProperties.Instance.ESpaceKey;
        }
    }

    public static ISitePropertiesInfo SiteProperties {
        get {
            return App.Espace(eSpaceKey).EspaceSiteProperties;
        }
    }

    public static IAppInfo App {
        get {
            return AppInfo.GetAppInfo();
        }
    }

    public static Tuple<Func<string, string>, Func<string, string>> GetEntityFunctions(string entityName) {
        entityFunctions ??= new Dictionary<string, Tuple<Func<string, string>, Func<string, string>>>() {
            			{ "orderdistributionconfig", new Tuple<Func<string, string>, Func<string, string>>(ENOrderDistributionConfigEntity.LocalViewName, ENOrderDistributionConfigEntity.AttributeDatabaseName)}, 
			{ "foliosapdata", new Tuple<Func<string, string>, Func<string, string>>(ENFolioSAPDataEntity.LocalViewName, ENFolioSAPDataEntity.AttributeDatabaseName)}, 
			{ "orderstatus", new Tuple<Func<string, string>, Func<string, string>>(ENOrderStatusEntity.LocalViewName, ENOrderStatusEntity.AttributeDatabaseName)}, 
			{ "proposalapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENProposalApprovalLevelEntity.LocalViewName, ENProposalApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "foliostatus", new Tuple<Func<string, string>, Func<string, string>>(ENFolioStatusEntity.LocalViewName, ENFolioStatusEntity.AttributeDatabaseName)}, 
			{ "orderitementries", new Tuple<Func<string, string>, Func<string, string>>(ENOrderItemEntriesEntity.LocalViewName, ENOrderItemEntriesEntity.AttributeDatabaseName)}, 
			{ "folioapproval", new Tuple<Func<string, string>, Func<string, string>>(ENFolioApprovalEntity.LocalViewName, ENFolioApprovalEntity.AttributeDatabaseName)}, 
			{ "columnsettings", new Tuple<Func<string, string>, Func<string, string>>(ENColumnSettingsEntity.LocalViewName, ENColumnSettingsEntity.AttributeDatabaseName)}, 
			{ "invoice", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceEntity.LocalViewName, ENInvoiceEntity.AttributeDatabaseName)}, 
			{ "ordermainitem", new Tuple<Func<string, string>, Func<string, string>>(ENOrderMainItemEntity.LocalViewName, ENOrderMainItemEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedrelations", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedRelationsEntity.LocalViewName, ENInvoiceExtendedRelationsEntity.AttributeDatabaseName)}, 
			{ "proposallogs", new Tuple<Func<string, string>, Func<string, string>>(ENProposalLogsEntity.LocalViewName, ENProposalLogsEntity.AttributeDatabaseName)}, 
			{ "orderretentiontype", new Tuple<Func<string, string>, Func<string, string>>(ENOrderRetentionTypeEntity.LocalViewName, ENOrderRetentionTypeEntity.AttributeDatabaseName)}, 
			{ "invoiceapproval", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceApprovalEntity.LocalViewName, ENInvoiceApprovalEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedtax", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedTaxEntity.LocalViewName, ENInvoiceExtendedTaxEntity.AttributeDatabaseName)}, 
			{ "requisitioncontractfile", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionContractFileEntity.LocalViewName, ENRequisitionContractFileEntity.AttributeDatabaseName)}, 
			{ "orderrequestfileapproval", new Tuple<Func<string, string>, Func<string, string>>(ENOrderRequestFileApprovalEntity.LocalViewName, ENOrderRequestFileApprovalEntity.AttributeDatabaseName)}, 
			{ "proposal", new Tuple<Func<string, string>, Func<string, string>>(ENProposalEntity.LocalViewName, ENProposalEntity.AttributeDatabaseName)}, 
			{ "ordersimportrequest", new Tuple<Func<string, string>, Func<string, string>>(ENOrdersImportRequestEntity.LocalViewName, ENOrdersImportRequestEntity.AttributeDatabaseName)}, 
			{ "orderrequestfileapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENOrderRequestFileApprovalLevelEntity.LocalViewName, ENOrderRequestFileApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "contractfiletype", new Tuple<Func<string, string>, Func<string, string>>(ENContractFileTypeEntity.LocalViewName, ENContractFileTypeEntity.AttributeDatabaseName)}, 
			{ "fileextended", new Tuple<Func<string, string>, Func<string, string>>(ENFileExtendedEntity.LocalViewName, ENFileExtendedEntity.AttributeDatabaseName)}, 
			{ "invoicestatus", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceStatusEntity.LocalViewName, ENInvoiceStatusEntity.AttributeDatabaseName)}, 
			{ "folio", new Tuple<Func<string, string>, Func<string, string>>(ENFolioEntity.LocalViewName, ENFolioEntity.AttributeDatabaseName)}, 
			{ "requisitionlogs", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionLogsEntity.LocalViewName, ENRequisitionLogsEntity.AttributeDatabaseName)}, 
			{ "invoicefile", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceFileEntity.LocalViewName, ENInvoiceFileEntity.AttributeDatabaseName)}, 
			{ "requisitionstatushistory", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionStatusHistoryEntity.LocalViewName, ENRequisitionStatusHistoryEntity.AttributeDatabaseName)}, 
			{ "reassignments", new Tuple<Func<string, string>, Func<string, string>>(ENReassignmentsEntity.LocalViewName, ENReassignmentsEntity.AttributeDatabaseName)}, 
			{ "logsaccounting", new Tuple<Func<string, string>, Func<string, string>>(ENLogsAccountingEntity.LocalViewName, ENLogsAccountingEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedforeigner", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedForeignerEntity.LocalViewName, ENInvoiceExtendedForeignerEntity.AttributeDatabaseName)}, 
			{ "folioextended", new Tuple<Func<string, string>, Func<string, string>>(ENFolioExtendedEntity.LocalViewName, ENFolioExtendedEntity.AttributeDatabaseName)}, 
			{ "folioregionseq", new Tuple<Func<string, string>, Func<string, string>>(ENFolioRegionSeqEntity.LocalViewName, ENFolioRegionSeqEntity.AttributeDatabaseName)}, 
			{ "proposalstatushistory", new Tuple<Func<string, string>, Func<string, string>>(ENProposalStatusHistoryEntity.LocalViewName, ENProposalStatusHistoryEntity.AttributeDatabaseName)}, 
			{ "requisitionaccconcepts", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionAccConceptsEntity.LocalViewName, ENRequisitionAccConceptsEntity.AttributeDatabaseName)}, 
			{ "invoicecomment", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceCommentEntity.LocalViewName, ENInvoiceCommentEntity.AttributeDatabaseName)}, 
			{ "proposaltype", new Tuple<Func<string, string>, Func<string, string>>(ENProposalTypeEntity.LocalViewName, ENProposalTypeEntity.AttributeDatabaseName)}, 
			{ "orderapproval", new Tuple<Func<string, string>, Func<string, string>>(ENOrderApprovalEntity.LocalViewName, ENOrderApprovalEntity.AttributeDatabaseName)}, 
			{ "ordermainitemstatus", new Tuple<Func<string, string>, Func<string, string>>(ENOrderMainItemStatusEntity.LocalViewName, ENOrderMainItemStatusEntity.AttributeDatabaseName)}, 
			{ "ordercomment", new Tuple<Func<string, string>, Func<string, string>>(ENOrderCommentEntity.LocalViewName, ENOrderCommentEntity.AttributeDatabaseName)}, 
			{ "folioapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENFolioApprovalLevelEntity.LocalViewName, ENFolioApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingprocessresponse", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingProcessResponseEntity.LocalViewName, ENInvoiceAccountingProcessResponseEntity.AttributeDatabaseName)}, 
			{ "ordercostcenter", new Tuple<Func<string, string>, Func<string, string>>(ENOrderCostCenterEntity.LocalViewName, ENOrderCostCenterEntity.AttributeDatabaseName)}, 
			{ "commenttype", new Tuple<Func<string, string>, Func<string, string>>(ENCommentTypeEntity.LocalViewName, ENCommentTypeEntity.AttributeDatabaseName)}, 
			{ "orderaccconcepts", new Tuple<Func<string, string>, Func<string, string>>(ENOrderAccConceptsEntity.LocalViewName, ENOrderAccConceptsEntity.AttributeDatabaseName)}, 
			{ "approvalstatus", new Tuple<Func<string, string>, Func<string, string>>(ENApprovalStatusEntity.LocalViewName, ENApprovalStatusEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedreceiver", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedReceiverEntity.LocalViewName, ENInvoiceExtendedReceiverEntity.AttributeDatabaseName)}, 
			{ "invoicetaxtype", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceTaxTypeEntity.LocalViewName, ENInvoiceTaxTypeEntity.AttributeDatabaseName)}, 
			{ "invoicelog", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceLogEntity.LocalViewName, ENInvoiceLogEntity.AttributeDatabaseName)}, 
			{ "foliolog", new Tuple<Func<string, string>, Func<string, string>>(ENFolioLogEntity.LocalViewName, ENFolioLogEntity.AttributeDatabaseName)}, 
			{ "foliocomment", new Tuple<Func<string, string>, Func<string, string>>(ENFolioCommentEntity.LocalViewName, ENFolioCommentEntity.AttributeDatabaseName)}, 
			{ "contractstatus", new Tuple<Func<string, string>, Func<string, string>>(ENContractStatusEntity.LocalViewName, ENContractStatusEntity.AttributeDatabaseName)}, 
			{ "logsaccountingsubject", new Tuple<Func<string, string>, Func<string, string>>(ENLogsAccountingSubjectEntity.LocalViewName, ENLogsAccountingSubjectEntity.AttributeDatabaseName)}, 
			{ "proposalstatus", new Tuple<Func<string, string>, Func<string, string>>(ENProposalStatusEntity.LocalViewName, ENProposalStatusEntity.AttributeDatabaseName)}, 
			{ "orderrequestfile", new Tuple<Func<string, string>, Func<string, string>>(ENOrderRequestFileEntity.LocalViewName, ENOrderRequestFileEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedcartaporte", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedCartaPorteEntity.LocalViewName, ENInvoiceExtendedCartaPorteEntity.AttributeDatabaseName)}, 
			{ "foliofiles", new Tuple<Func<string, string>, Func<string, string>>(ENFolioFilesEntity.LocalViewName, ENFolioFilesEntity.AttributeDatabaseName)}, 
			{ "invoicestatushistory", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceStatusHistoryEntity.LocalViewName, ENInvoiceStatusHistoryEntity.AttributeDatabaseName)}, 
			{ "requisition", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionEntity.LocalViewName, ENRequisitionEntity.AttributeDatabaseName)}, 
			{ "requisitionversion", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionVersionEntity.LocalViewName, ENRequisitionVersionEntity.AttributeDatabaseName)}, 
			{ "requisitionapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionApprovalLevelEntity.LocalViewName, ENRequisitionApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "folioitems", new Tuple<Func<string, string>, Func<string, string>>(ENFolioItemsEntity.LocalViewName, ENFolioItemsEntity.AttributeDatabaseName)}, 
			{ "ordercontractfile", new Tuple<Func<string, string>, Func<string, string>>(ENOrderContractFileEntity.LocalViewName, ENOrderContractFileEntity.AttributeDatabaseName)}, 
			{ "orderaccounting", new Tuple<Func<string, string>, Func<string, string>>(ENOrderAccountingEntity.LocalViewName, ENOrderAccountingEntity.AttributeDatabaseName)}, 
			{ "ordermain", new Tuple<Func<string, string>, Func<string, string>>(ENOrderMainEntity.LocalViewName, ENOrderMainEntity.AttributeDatabaseName)}, 
			{ "orderlogs", new Tuple<Func<string, string>, Func<string, string>>(ENOrderLogsEntity.LocalViewName, ENOrderLogsEntity.AttributeDatabaseName)}, 
			{ "invoiceapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceApprovalLevelEntity.LocalViewName, ENInvoiceApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "fileimportlog", new Tuple<Func<string, string>, Func<string, string>>(ENFileImportLogEntity.LocalViewName, ENFileImportLogEntity.AttributeDatabaseName)}, 
			{ "invoiceextendeditem", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedItemEntity.LocalViewName, ENInvoiceExtendedItemEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingservices", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingServicesEntity.LocalViewName, ENInvoiceAccountingServicesEntity.AttributeDatabaseName)}, 
			{ "requisitionservice", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionServiceEntity.LocalViewName, ENRequisitionServiceEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingprocessstatus", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingProcessStatusEntity.LocalViewName, ENInvoiceAccountingProcessStatusEntity.AttributeDatabaseName)}, 
			{ "invoicepolizastorage", new Tuple<Func<string, string>, Func<string, string>>(ENInvoicePolizaStorageEntity.LocalViewName, ENInvoicePolizaStorageEntity.AttributeDatabaseName)}, 
			{ "orderservice", new Tuple<Func<string, string>, Func<string, string>>(ENOrderServiceEntity.LocalViewName, ENOrderServiceEntity.AttributeDatabaseName)}, 
			{ "requisitionapproval", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionApprovalEntity.LocalViewName, ENRequisitionApprovalEntity.AttributeDatabaseName)}, 
			{ "orderdetail", new Tuple<Func<string, string>, Func<string, string>>(ENOrderDetailEntity.LocalViewName, ENOrderDetailEntity.AttributeDatabaseName)}, 
			{ "requisitionstatus", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionStatusEntity.LocalViewName, ENRequisitionStatusEntity.AttributeDatabaseName)}, 
			{ "proposalcomment", new Tuple<Func<string, string>, Func<string, string>>(ENProposalCommentEntity.LocalViewName, ENProposalCommentEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingentries", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingEntriesEntity.LocalViewName, ENInvoiceAccountingEntriesEntity.AttributeDatabaseName)}, 
			{ "proposallineapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENProposalLineApprovalLevelEntity.LocalViewName, ENProposalLineApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedissuer", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedIssuerEntity.LocalViewName, ENInvoiceExtendedIssuerEntity.AttributeDatabaseName)}, 
			{ "file3", new Tuple<Func<string, string>, Func<string, string>>(ENFile3Entity.LocalViewName, ENFile3Entity.AttributeDatabaseName)}, 
			{ "proposalapproval", new Tuple<Func<string, string>, Func<string, string>>(ENProposalApprovalEntity.LocalViewName, ENProposalApprovalEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingprocesslines_f43", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingProcessLines_F43Entity.LocalViewName, ENInvoiceAccountingProcessLines_F43Entity.AttributeDatabaseName)}, 
			{ "orderfile", new Tuple<Func<string, string>, Func<string, string>>(ENOrderFileEntity.LocalViewName, ENOrderFileEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingprocess", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingProcessEntity.LocalViewName, ENInvoiceAccountingProcessEntity.AttributeDatabaseName)}, 
			{ "orderapprovallevel", new Tuple<Func<string, string>, Func<string, string>>(ENOrderApprovalLevelEntity.LocalViewName, ENOrderApprovalLevelEntity.AttributeDatabaseName)}, 
			{ "proposalcommentfile", new Tuple<Func<string, string>, Func<string, string>>(ENProposalCommentFileEntity.LocalViewName, ENProposalCommentFileEntity.AttributeDatabaseName)}, 
			{ "actiontimestamps", new Tuple<Func<string, string>, Func<string, string>>(ENActionTimestampsEntity.LocalViewName, ENActionTimestampsEntity.AttributeDatabaseName)}, 
			{ "requisitionaccounting", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionAccountingEntity.LocalViewName, ENRequisitionAccountingEntity.AttributeDatabaseName)}, 
			{ "invoicepoliza", new Tuple<Func<string, string>, Func<string, string>>(ENInvoicePolizaEntity.LocalViewName, ENInvoicePolizaEntity.AttributeDatabaseName)}, 
			{ "invoiceextendedmorecharges", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedMoreChargesEntity.LocalViewName, ENInvoiceExtendedMoreChargesEntity.AttributeDatabaseName)}, 
			{ "specialapproval", new Tuple<Func<string, string>, Func<string, string>>(ENSpecialApprovalEntity.LocalViewName, ENSpecialApprovalEntity.AttributeDatabaseName)}, 
			{ "requisitioncostcenter", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionCostCenterEntity.LocalViewName, ENRequisitionCostCenterEntity.AttributeDatabaseName)}, 
			{ "invoiceaccountingprocessretentions", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingProcessRetentionsEntity.LocalViewName, ENInvoiceAccountingProcessRetentionsEntity.AttributeDatabaseName)}, 
			{ "invoiceextendeditemtax", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedItemTaxEntity.LocalViewName, ENInvoiceExtendedItemTaxEntity.AttributeDatabaseName)}, 
			{ "folioobservations", new Tuple<Func<string, string>, Func<string, string>>(ENFolioObservationsEntity.LocalViewName, ENFolioObservationsEntity.AttributeDatabaseName)}, 
			{ "requisitionfile2", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionFile2Entity.LocalViewName, ENRequisitionFile2Entity.AttributeDatabaseName)}, 
			{ "invoiceextendedsellodigital", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedSelloDigitalEntity.LocalViewName, ENInvoiceExtendedSelloDigitalEntity.AttributeDatabaseName)}, 
			{ "requisitioncomment", new Tuple<Func<string, string>, Func<string, string>>(ENRequisitionCommentEntity.LocalViewName, ENRequisitionCommentEntity.AttributeDatabaseName)}, 
			{ "importstatus", new Tuple<Func<string, string>, Func<string, string>>(ENImportStatusEntity.LocalViewName, ENImportStatusEntity.AttributeDatabaseName)}, 
			{ "proposalline", new Tuple<Func<string, string>, Func<string, string>>(ENProposalLineEntity.LocalViewName, ENProposalLineEntity.AttributeDatabaseName)}, 
			{ "invoiceaccounting", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceAccountingEntity.LocalViewName, ENInvoiceAccountingEntity.AttributeDatabaseName)}, 
			{ "orderrequestfilecomment", new Tuple<Func<string, string>, Func<string, string>>(ENOrderRequestFileCommentEntity.LocalViewName, ENOrderRequestFileCommentEntity.AttributeDatabaseName)}, 
			{ "invoiceextended", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceExtendedEntity.LocalViewName, ENInvoiceExtendedEntity.AttributeDatabaseName)}, 
			{ "processstatus", new Tuple<Func<string, string>, Func<string, string>>(ENProcessStatusEntity.LocalViewName, ENProcessStatusEntity.AttributeDatabaseName)}, 
			{ "activitystatus", new Tuple<Func<string, string>, Func<string, string>>(ENActivityStatusEntity.LocalViewName, ENActivityStatusEntity.AttributeDatabaseName)}, 
			{ "user", new Tuple<Func<string, string>, Func<string, string>>(ENUserEntity.LocalViewName, ENUserEntity.AttributeDatabaseName)}, 
			{ "activitykind", new Tuple<Func<string, string>, Func<string, string>>(ENActivityKindEntity.LocalViewName, ENActivityKindEntity.AttributeDatabaseName)}, 
			{ "aicontenttype", new Tuple<Func<string, string>, Func<string, string>>(ENAIContentTypeEntity.LocalViewName, ENAIContentTypeEntity.AttributeDatabaseName)}, 
			{ "airole", new Tuple<Func<string, string>, Func<string, string>>(ENAIRoleEntity.LocalViewName, ENAIRoleEntity.AttributeDatabaseName)}, 
			{ "approvalprocesslevel", new Tuple<Func<string, string>, Func<string, string>>(ENApprovalProcessLevelEntity.LocalViewName, ENApprovalProcessLevelEntity.AttributeDatabaseName)}, 
			{ "approvalprocess", new Tuple<Func<string, string>, Func<string, string>>(ENApprovalProcessEntity.LocalViewName, ENApprovalProcessEntity.AttributeDatabaseName)}, 
			{ "specialworkflowuploadpuestos", new Tuple<Func<string, string>, Func<string, string>>(ENSpecialWorkflowUploadPuestosEntity.LocalViewName, ENSpecialWorkflowUploadPuestosEntity.AttributeDatabaseName)}, 
			{ "processtype", new Tuple<Func<string, string>, Func<string, string>>(ENProcessTypeEntity.LocalViewName, ENProcessTypeEntity.AttributeDatabaseName)}, 
			{ "specialworkflows", new Tuple<Func<string, string>, Func<string, string>>(ENSpecialWorkflowsEntity.LocalViewName, ENSpecialWorkflowsEntity.AttributeDatabaseName)}, 
			{ "approvalprocessmatrix", new Tuple<Func<string, string>, Func<string, string>>(ENApprovalProcessMatrixEntity.LocalViewName, ENApprovalProcessMatrixEntity.AttributeDatabaseName)}, 
			{ "seriestype", new Tuple<Func<string, string>, Func<string, string>>(ENSeriesTypeEntity.LocalViewName, ENSeriesTypeEntity.AttributeDatabaseName)}, 
			{ "legendposition", new Tuple<Func<string, string>, Func<string, string>>(ENLegendPositionEntity.LocalViewName, ENLegendPositionEntity.AttributeDatabaseName)}, 
			{ "legendlayout", new Tuple<Func<string, string>, Func<string, string>>(ENLegendLayoutEntity.LocalViewName, ENLegendLayoutEntity.AttributeDatabaseName)}, 
			{ "operator", new Tuple<Func<string, string>, Func<string, string>>(ENOperatorEntity.LocalViewName, ENOperatorEntity.AttributeDatabaseName)}, 
			{ "currency", new Tuple<Func<string, string>, Func<string, string>>(ENCurrencyEntity.LocalViewName, ENCurrencyEntity.AttributeDatabaseName)}, 
			{ "dayofweek", new Tuple<Func<string, string>, Func<string, string>>(ENDayOfWeekEntity.LocalViewName, ENDayOfWeekEntity.AttributeDatabaseName)}, 
			{ "bank", new Tuple<Func<string, string>, Func<string, string>>(ENBankEntity.LocalViewName, ENBankEntity.AttributeDatabaseName)}, 
			{ "marginsize", new Tuple<Func<string, string>, Func<string, string>>(ENMarginSizeEntity.LocalViewName, ENMarginSizeEntity.AttributeDatabaseName)}, 
			{ "papersize", new Tuple<Func<string, string>, Func<string, string>>(ENPaperSizeEntity.LocalViewName, ENPaperSizeEntity.AttributeDatabaseName)}, 
			{ "audit", new Tuple<Func<string, string>, Func<string, string>>(ENAuditEntity.LocalViewName, ENAuditEntity.AttributeDatabaseName)}, 
			{ "origin", new Tuple<Func<string, string>, Func<string, string>>(ENOriginEntity.LocalViewName, ENOriginEntity.AttributeDatabaseName)}, 
			{ "sidemenubehavior", new Tuple<Func<string, string>, Func<string, string>>(ENSideMenuBehaviorEntity.LocalViewName, ENSideMenuBehaviorEntity.AttributeDatabaseName)}, 
			{ "size", new Tuple<Func<string, string>, Func<string, string>>(ENSizeEntity.LocalViewName, ENSizeEntity.AttributeDatabaseName)}, 
			{ "guttersize", new Tuple<Func<string, string>, Func<string, string>>(ENGutterSizeEntity.LocalViewName, ENGutterSizeEntity.AttributeDatabaseName)}, 
			{ "orientation", new Tuple<Func<string, string>, Func<string, string>>(ENOrientationEntity.LocalViewName, ENOrientationEntity.AttributeDatabaseName)}, 
			{ "datepickertimeformat", new Tuple<Func<string, string>, Func<string, string>>(ENDatePickerTimeFormatEntity.LocalViewName, ENDatePickerTimeFormatEntity.AttributeDatabaseName)}, 
			{ "accordionicontype", new Tuple<Func<string, string>, Func<string, string>>(ENAccordionIconTypeEntity.LocalViewName, ENAccordionIconTypeEntity.AttributeDatabaseName)}, 
			{ "direction", new Tuple<Func<string, string>, Func<string, string>>(ENDirectionEntity.LocalViewName, ENDirectionEntity.AttributeDatabaseName)}, 
			{ "breakcolumns", new Tuple<Func<string, string>, Func<string, string>>(ENBreakColumnsEntity.LocalViewName, ENBreakColumnsEntity.AttributeDatabaseName)}, 
			{ "shape", new Tuple<Func<string, string>, Func<string, string>>(ENShapeEntity.LocalViewName, ENShapeEntity.AttributeDatabaseName)}, 
			{ "position", new Tuple<Func<string, string>, Func<string, string>>(ENPositionEntity.LocalViewName, ENPositionEntity.AttributeDatabaseName)}, 
			{ "trigger", new Tuple<Func<string, string>, Func<string, string>>(ENTriggerEntity.LocalViewName, ENTriggerEntity.AttributeDatabaseName)}, 
			{ "space", new Tuple<Func<string, string>, Func<string, string>>(ENSpaceEntity.LocalViewName, ENSpaceEntity.AttributeDatabaseName)}, 
			{ "booleantypes", new Tuple<Func<string, string>, Func<string, string>>(ENBooleanTypesEntity.LocalViewName, ENBooleanTypesEntity.AttributeDatabaseName)}, 
			{ "accordioniconposition", new Tuple<Func<string, string>, Func<string, string>>(ENAccordionIconPositionEntity.LocalViewName, ENAccordionIconPositionEntity.AttributeDatabaseName)}, 
			{ "scrollbarstyle", new Tuple<Func<string, string>, Func<string, string>>(ENScrollbarStyleEntity.LocalViewName, ENScrollbarStyleEntity.AttributeDatabaseName)}, 
			{ "color", new Tuple<Func<string, string>, Func<string, string>>(ENColorEntity.LocalViewName, ENColorEntity.AttributeDatabaseName)}, 
			{ "steps", new Tuple<Func<string, string>, Func<string, string>>(ENStepsEntity.LocalViewName, ENStepsEntity.AttributeDatabaseName)}, 
			{ "videostate", new Tuple<Func<string, string>, Func<string, string>>(ENVideoStateEntity.LocalViewName, ENVideoStateEntity.AttributeDatabaseName)}, 
			{ "datepickerweekday", new Tuple<Func<string, string>, Func<string, string>>(ENDatePickerWeekDayEntity.LocalViewName, ENDatePickerWeekDayEntity.AttributeDatabaseName)}, 
			{ "roleconcept", new Tuple<Func<string, string>, Func<string, string>>(ENRoleConceptEntity.LocalViewName, ENRoleConceptEntity.AttributeDatabaseName)}, 
			{ "userapplicationrole", new Tuple<Func<string, string>, Func<string, string>>(ENUserApplicationRoleEntity.LocalViewName, ENUserApplicationRoleEntity.AttributeDatabaseName)}, 
			{ "concept", new Tuple<Func<string, string>, Func<string, string>>(ENConceptEntity.LocalViewName, ENConceptEntity.AttributeDatabaseName)}, 
			{ "applicationrole", new Tuple<Func<string, string>, Func<string, string>>(ENApplicationRoleEntity.LocalViewName, ENApplicationRoleEntity.AttributeDatabaseName)}, 
			{ "userapplicationroletempbyconcept", new Tuple<Func<string, string>, Func<string, string>>(ENUserApplicationRoleTempByConceptEntity.LocalViewName, ENUserApplicationRoleTempByConceptEntity.AttributeDatabaseName)}, 
			{ "entrarole", new Tuple<Func<string, string>, Func<string, string>>(ENEntraRoleEntity.LocalViewName, ENEntraRoleEntity.AttributeDatabaseName)}, 
			{ "userapplicationroletemp", new Tuple<Func<string, string>, Func<string, string>>(ENUserApplicationRoleTempEntity.LocalViewName, ENUserApplicationRoleTempEntity.AttributeDatabaseName)}, 
			{ "rolestatus", new Tuple<Func<string, string>, Func<string, string>>(ENRoleStatusEntity.LocalViewName, ENRoleStatusEntity.AttributeDatabaseName)}, 
			{ "userextension", new Tuple<Func<string, string>, Func<string, string>>(ENUserExtensionEntity.LocalViewName, ENUserExtensionEntity.AttributeDatabaseName)}, 
			{ "deletedstorage", new Tuple<Func<string, string>, Func<string, string>>(ENDeletedStorageEntity.LocalViewName, ENDeletedStorageEntity.AttributeDatabaseName)}, 
			{ "internalconcept", new Tuple<Func<string, string>, Func<string, string>>(ENInternalConceptEntity.LocalViewName, ENInternalConceptEntity.AttributeDatabaseName)}, 
			{ "storage", new Tuple<Func<string, string>, Func<string, string>>(ENStorageEntity.LocalViewName, ENStorageEntity.AttributeDatabaseName)}, 
			{ "accountingaccounts_servicetype", new Tuple<Func<string, string>, Func<string, string>>(ENAccountingAccounts_ServiceTypeEntity.LocalViewName, ENAccountingAccounts_ServiceTypeEntity.AttributeDatabaseName)}, 
			{ "deposittype", new Tuple<Func<string, string>, Func<string, string>>(ENDepositTypeEntity.LocalViewName, ENDepositTypeEntity.AttributeDatabaseName)}, 
			{ "accountingdatatype", new Tuple<Func<string, string>, Func<string, string>>(ENAccountingDataTypeEntity.LocalViewName, ENAccountingDataTypeEntity.AttributeDatabaseName)}, 
			{ "insurancetype", new Tuple<Func<string, string>, Func<string, string>>(ENInsuranceTypeEntity.LocalViewName, ENInsuranceTypeEntity.AttributeDatabaseName)}, 
			{ "manuals", new Tuple<Func<string, string>, Func<string, string>>(ENManualsEntity.LocalViewName, ENManualsEntity.AttributeDatabaseName)}, 
			{ "paymentoptions", new Tuple<Func<string, string>, Func<string, string>>(ENPaymentOptionsEntity.LocalViewName, ENPaymentOptionsEntity.AttributeDatabaseName)}, 
			{ "manualfile", new Tuple<Func<string, string>, Func<string, string>>(ENManualFileEntity.LocalViewName, ENManualFileEntity.AttributeDatabaseName)}, 
			{ "customsettings", new Tuple<Func<string, string>, Func<string, string>>(ENCustomSettingsEntity.LocalViewName, ENCustomSettingsEntity.AttributeDatabaseName)}, 
			{ "serviceformat", new Tuple<Func<string, string>, Func<string, string>>(ENServiceFormatEntity.LocalViewName, ENServiceFormatEntity.AttributeDatabaseName)}, 
			{ "invoiceusage", new Tuple<Func<string, string>, Func<string, string>>(ENInvoiceUsageEntity.LocalViewName, ENInvoiceUsageEntity.AttributeDatabaseName)}, 
			{ "subdirection", new Tuple<Func<string, string>, Func<string, string>>(ENSubdirectionEntity.LocalViewName, ENSubdirectionEntity.AttributeDatabaseName)}, 
			{ "applicanttelceldirection", new Tuple<Func<string, string>, Func<string, string>>(ENApplicantTelcelDirectionEntity.LocalViewName, ENApplicantTelcelDirectionEntity.AttributeDatabaseName)}, 
			{ "cfditype", new Tuple<Func<string, string>, Func<string, string>>(ENCFDITypeEntity.LocalViewName, ENCFDITypeEntity.AttributeDatabaseName)}, 
			{ "purchasinggroup", new Tuple<Func<string, string>, Func<string, string>>(ENPurchasingGroupEntity.LocalViewName, ENPurchasingGroupEntity.AttributeDatabaseName)}, 
			{ "taxindicator", new Tuple<Func<string, string>, Func<string, string>>(ENTaxIndicatorEntity.LocalViewName, ENTaxIndicatorEntity.AttributeDatabaseName)}, 
			{ "distribution", new Tuple<Func<string, string>, Func<string, string>>(ENDistributionEntity.LocalViewName, ENDistributionEntity.AttributeDatabaseName)}, 
			{ "retentiontypes", new Tuple<Func<string, string>, Func<string, string>>(ENRetentionTypesEntity.LocalViewName, ENRetentionTypesEntity.AttributeDatabaseName)}, 
			{ "user_extended_internal", new Tuple<Func<string, string>, Func<string, string>>(ENUser_Extended_InternalEntity.LocalViewName, ENUser_Extended_InternalEntity.AttributeDatabaseName)}, 
			{ "ivaexceptionm9suppliers", new Tuple<Func<string, string>, Func<string, string>>(ENIVAExceptionM9SuppliersEntity.LocalViewName, ENIVAExceptionM9SuppliersEntity.AttributeDatabaseName)}, 
			{ "user_preferences", new Tuple<Func<string, string>, Func<string, string>>(ENUser_PreferencesEntity.LocalViewName, ENUser_PreferencesEntity.AttributeDatabaseName)}, 
			{ "documenttype", new Tuple<Func<string, string>, Func<string, string>>(ENDocumentTypeEntity.LocalViewName, ENDocumentTypeEntity.AttributeDatabaseName)}, 
			{ "supplieruser", new Tuple<Func<string, string>, Func<string, string>>(ENSupplierUserEntity.LocalViewName, ENSupplierUserEntity.AttributeDatabaseName)}, 
			{ "company", new Tuple<Func<string, string>, Func<string, string>>(ENCompanyEntity.LocalViewName, ENCompanyEntity.AttributeDatabaseName)}, 
			{ "department", new Tuple<Func<string, string>, Func<string, string>>(ENDepartmentEntity.LocalViewName, ENDepartmentEntity.AttributeDatabaseName)}, 
			{ "applicant", new Tuple<Func<string, string>, Func<string, string>>(ENApplicantEntity.LocalViewName, ENApplicantEntity.AttributeDatabaseName)}, 
			{ "approvalprocesstype", new Tuple<Func<string, string>, Func<string, string>>(ENApprovalProcessTypeEntity.LocalViewName, ENApprovalProcessTypeEntity.AttributeDatabaseName)}, 
			{ "supplier", new Tuple<Func<string, string>, Func<string, string>>(ENSupplierEntity.LocalViewName, ENSupplierEntity.AttributeDatabaseName)}, 
			{ "costcentersap", new Tuple<Func<string, string>, Func<string, string>>(ENCostCenterSAPEntity.LocalViewName, ENCostCenterSAPEntity.AttributeDatabaseName)}, 
			{ "accountableguide", new Tuple<Func<string, string>, Func<string, string>>(ENAccountableGuideEntity.LocalViewName, ENAccountableGuideEntity.AttributeDatabaseName)}, 
			{ "specialpostdeliveryauthorization", new Tuple<Func<string, string>, Func<string, string>>(ENSpecialPostDeliveryAuthorizationEntity.LocalViewName, ENSpecialPostDeliveryAuthorizationEntity.AttributeDatabaseName)}, 
			{ "telceldirection", new Tuple<Func<string, string>, Func<string, string>>(ENTelcelDirectionEntity.LocalViewName, ENTelcelDirectionEntity.AttributeDatabaseName)}, 
			{ "frequency", new Tuple<Func<string, string>, Func<string, string>>(ENFrequencyEntity.LocalViewName, ENFrequencyEntity.AttributeDatabaseName)}, 
			{ "management", new Tuple<Func<string, string>, Func<string, string>>(ENManagementEntity.LocalViewName, ENManagementEntity.AttributeDatabaseName)}, 
			{ "segmentaccgroup", new Tuple<Func<string, string>, Func<string, string>>(ENSegmentAccGroupEntity.LocalViewName, ENSegmentAccGroupEntity.AttributeDatabaseName)}, 
			{ "appconcept", new Tuple<Func<string, string>, Func<string, string>>(ENAppConceptEntity.LocalViewName, ENAppConceptEntity.AttributeDatabaseName)}, 
			{ "invoicesusageaccounts", new Tuple<Func<string, string>, Func<string, string>>(ENInvoicesUsageAccountsEntity.LocalViewName, ENInvoicesUsageAccountsEntity.AttributeDatabaseName)}, 
			{ "customsettingvalue", new Tuple<Func<string, string>, Func<string, string>>(ENCustomSettingValueEntity.LocalViewName, ENCustomSettingValueEntity.AttributeDatabaseName)}, 
			{ "entryblockdates", new Tuple<Func<string, string>, Func<string, string>>(ENEntryBlockDatesEntity.LocalViewName, ENEntryBlockDatesEntity.AttributeDatabaseName)}, 
			{ "project_asset_service", new Tuple<Func<string, string>, Func<string, string>>(ENProject_Asset_ServiceEntity.LocalViewName, ENProject_Asset_ServiceEntity.AttributeDatabaseName)}, 
			{ "manualuserarea", new Tuple<Func<string, string>, Func<string, string>>(ENManualUserAreaEntity.LocalViewName, ENManualUserAreaEntity.AttributeDatabaseName)}, 
			{ "paymentterms", new Tuple<Func<string, string>, Func<string, string>>(ENPaymentTermsEntity.LocalViewName, ENPaymentTermsEntity.AttributeDatabaseName)}, 
			{ "paymentways", new Tuple<Func<string, string>, Func<string, string>>(ENPaymentWaysEntity.LocalViewName, ENPaymentWaysEntity.AttributeDatabaseName)}, 
			{ "userarea", new Tuple<Func<string, string>, Func<string, string>>(ENUserAreaEntity.LocalViewName, ENUserAreaEntity.AttributeDatabaseName)}, 
			{ "advancepaymenttype", new Tuple<Func<string, string>, Func<string, string>>(ENAdvancePaymentTypeEntity.LocalViewName, ENAdvancePaymentTypeEntity.AttributeDatabaseName)}, 
			{ "paymentmethods", new Tuple<Func<string, string>, Func<string, string>>(ENPaymentMethodsEntity.LocalViewName, ENPaymentMethodsEntity.AttributeDatabaseName)}, 
			{ "segmentaccgrouptelceldir", new Tuple<Func<string, string>, Func<string, string>>(ENSegmentAccGroupTelcelDirEntity.LocalViewName, ENSegmentAccGroupTelcelDirEntity.AttributeDatabaseName)}, 
			{ "supplierdetail", new Tuple<Func<string, string>, Func<string, string>>(ENSupplierDetailEntity.LocalViewName, ENSupplierDetailEntity.AttributeDatabaseName)}, 
			{ "fiscalyearexceptions", new Tuple<Func<string, string>, Func<string, string>>(ENFiscalYearExceptionsEntity.LocalViewName, ENFiscalYearExceptionsEntity.AttributeDatabaseName)}, 
			{ "businessvaluecategory", new Tuple<Func<string, string>, Func<string, string>>(ENBusinessValueCategoryEntity.LocalViewName, ENBusinessValueCategoryEntity.AttributeDatabaseName)}, 
			{ "sustainability", new Tuple<Func<string, string>, Func<string, string>>(ENSustainabilityEntity.LocalViewName, ENSustainabilityEntity.AttributeDatabaseName)}, 
			{ "virtualstore", new Tuple<Func<string, string>, Func<string, string>>(ENVirtualStoreEntity.LocalViewName, ENVirtualStoreEntity.AttributeDatabaseName)}, 
			{ "region", new Tuple<Func<string, string>, Func<string, string>>(ENRegionEntity.LocalViewName, ENRegionEntity.AttributeDatabaseName)}, 
			{ "processtypedatesallowed", new Tuple<Func<string, string>, Func<string, string>>(ENProcessTypeDatesAllowedEntity.LocalViewName, ENProcessTypeDatesAllowedEntity.AttributeDatabaseName)}, 
			{ "businessvaluesubcategory", new Tuple<Func<string, string>, Func<string, string>>(ENBusinessValueSubcategoryEntity.LocalViewName, ENBusinessValueSubcategoryEntity.AttributeDatabaseName)}, 
			{ "entradomain", new Tuple<Func<string, string>, Func<string, string>>(ENEntraDomainEntity.LocalViewName, ENEntraDomainEntity.AttributeDatabaseName)}
        };
        entityFunctions.TryGetValue(entityName, out Tuple<Func<string, string>, Func<string, string>> result);
        return result;
    }

    private static readonly Lazy<IResourceManager> ResourceManager = new(() => new EmbeddedResourceManager($"{StaticProperties.Instance.ESpaceName}Language", Assembly.GetExecutingAssembly()));

    public static string GetStringResource(string key, string defaultValue) {
        var requestContext = AppInfo.GetAppInfo().RequestContext;
        return ResourceManager.Value.GetString(key, requestContext.CurrentCulture) ?? defaultValue;
    }

    public static string GetEffectiveLocale() {
        return GetStringResource("EffectiveLocale", "");
    }

    internal class StaticProperties : IModuleStaticProperties {
        private static readonly Lazy<StaticProperties> InstanceHolder = new(() => new StaticProperties());

        public static StaticProperties Instance {
            get {
                return InstanceHolder.Value;
            }
        }

        private static readonly ObjectKey eSpaceKey = ObjectKey.Parse("588dd3e9-ffc1-4591-bd4e-2f57e6c30828") ?? ObjectKey.Dummy;
        public ObjectKey ESpaceKey {
            get {
                return eSpaceKey;
            }
        }

        // The name of the eSpace, should be used for code generation purposes and identifiers.
        public string ESpaceName {
            get {
                return "ConectaProveedores";
            }
        }

        public bool DebugMode {
            get {
                return false;
            }
        }

        public void RunDebuggerEndRequest() {
            
        }

        public ObjectKey ESpaceId { get { return eSpaceId; } }
    }
}
