namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Rei7MmsJtkSqS99kWrNQEg)
///  <code>RC_acb134934352a9d72fd2cc0509d2f469</code> that represent
/// s
///  <code>UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAc
/// countingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_Serv
/// iceRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord
public partial struct RC_acb134934352a9d72fd2cc0509d2f469 : ITypedRecord<RC_acb134934352a9d72fd2cc0509d2f469> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdDontShowAction = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LJ45sa1N0YaIaQ3Ebk03wg");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdIsUserFromThisRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ORPO+yzvSoJSOlQpkhRWXg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public bool ssDontShowAction;

public bool ssIsSelected;

public bool ssIsUserFromThisRegion;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_acb134934352a9d72fd2cc0509d2f469() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssDontShowAction = false;
ssIsSelected = false;
ssIsUserFromThisRegion = false;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[13];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(10,false);
    all[5] = new BitArray(58,false);
    all[6] = new BitArray(25,false);
    all[7] = new BitArray(21,false);
    all[8] = new BitArray(7,false);
    all[9] = new BitArray(11,false);
    all[10] = new BitArray(28,false);
    all[11] = new BitArray(7,false);
    all[12] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[10];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[11];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[12];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    ssENInvoiceStatus.OptimizedAttributes = value[3];
    ssENApprovalStatus.OptimizedAttributes = value[4];
    ssENRequisition.OptimizedAttributes = value[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[6];
    ssENInvoiceAccounting.OptimizedAttributes = value[7];
    ssENApplicationRole.OptimizedAttributes = value[8];
    ssENCompany.OptimizedAttributes = value[9];
    ssENSupplier.OptimizedAttributes = value[10];
    ssENProject_Asset_Service.OptimizedAttributes = value[11];
    ssENRegion.OptimizedAttributes = value[12];
    }
}
get{
    BitArray[] all = new BitArray[13];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    all[3] = ssENInvoiceStatus.OptimizedAttributes;
    all[4] = ssENApprovalStatus.OptimizedAttributes;
    all[5] = ssENRequisition.OptimizedAttributes;
    all[6] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[7] = ssENInvoiceAccounting.OptimizedAttributes;
    all[8] = ssENApplicationRole.OptimizedAttributes;
    all[9] = ssENCompany.OptimizedAttributes;
    all[10] = ssENSupplier.OptimizedAttributes;
    all[11] = ssENProject_Asset_Service.OptimizedAttributes;
    all[12] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
ssENRegion.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_acb134934352a9d72fd2cc0509d2f469 r) {
this = r;
}


public static bool operator == (RC_acb134934352a9d72fd2cc0509d2f469 a, RC_acb134934352a9d72fd2cc0509d2f469 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssDontShowAction != b.ssDontShowAction) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssIsUserFromThisRegion != b.ssIsUserFromThisRegion) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_acb134934352a9d72fd2cc0509d2f469 a, RC_acb134934352a9d72fd2cc0509d2f469 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_acb134934352a9d72fd2cc0509d2f469)) return false;
return (this == (RC_acb134934352a9d72fd2cc0509d2f469)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssDontShowAction.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssIsUserFromThisRegion.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_acb134934352a9d72fd2cc0509d2f469 Duplicate() {
RC_acb134934352a9d72fd2cc0509d2f469 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssDontShowAction = this.ssDontShowAction;
t.ssIsSelected = this.ssIsSelected;
t.ssIsUserFromThisRegion = this.ssIsUserFromThisRegion;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "dontshowaction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DontShowAction")) variable.Value = ssDontShowAction; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
} else if (head == "isuserfromthisregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsUserFromThisRegion")) variable.Value = ssIsUserFromThisRegion; else variable.Optimized = true;
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdDontShowAction) {
return ssDontShowAction;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdIsUserFromThisRegion) {
return ssIsUserFromThisRegion;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdDontShowAction.Key.AsGuid) {
return ssDontShowAction;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdIsUserFromThisRegion.Key.AsGuid) {
return ssIsUserFromThisRegion;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssDontShowAction = (bool) other.AttributeGet(IdDontShowAction);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssIsUserFromThisRegion = (bool) other.AttributeGet(IdIsUserFromThisRegion);
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_acb134934352a9d72fd2cc0509d2f469
/// <summary>
/// RecordList type
///  <code>UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAc
/// countingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_Serv
/// iceRegionRecordList</code> that represents a record list of <code>User, Invoice, InvoiceApproval,
///  InvoiceStatus, ApprovalStatus, Requisition, InvoiceApprovalLevel, InvoiceAccounting
/// , ApplicationRole, Boolean, Boolean, Boolean, Company, Supplier, Project_Asset_Service,
///  Region</code>
/// </summary>
public partial class RL_c5ca0a80d78493d156f2b1a68d86a831 : GenericRecordList<RC_acb134934352a9d72fd2cc0509d2f469>, IEnumerable, IEnumerator {

protected override RC_acb134934352a9d72fd2cc0509d2f469 GetElementDefaultValue() {
return new RC_acb134934352a9d72fd2cc0509d2f469();
}

public T[] ToArray<T>(Func<RC_acb134934352a9d72fd2cc0509d2f469, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c5ca0a80d78493d156f2b1a68d86a831 recordList, Func<RC_acb134934352a9d72fd2cc0509d2f469, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c5ca0a80d78493d156f2b1a68d86a831(RC_acb134934352a9d72fd2cc0509d2f469[] array) {
  RL_c5ca0a80d78493d156f2b1a68d86a831 result = new RL_c5ca0a80d78493d156f2b1a68d86a831();
result.InnerFromArray(array);
    return result;
}

public static RL_c5ca0a80d78493d156f2b1a68d86a831 ToList<T>(T[] array, Func <T, RC_acb134934352a9d72fd2cc0509d2f469> converter) {
  RL_c5ca0a80d78493d156f2b1a68d86a831 result = new RL_c5ca0a80d78493d156f2b1a68d86a831();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c5ca0a80d78493d156f2b1a68d86a831 FromRestList<T>(RestList<T> restList, Func <T, RC_acb134934352a9d72fd2cc0509d2f469> converter) {
  RL_c5ca0a80d78493d156f2b1a68d86a831 result = new RL_c5ca0a80d78493d156f2b1a68d86a831();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c5ca0a80d78493d156f2b1a68d86a831() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[13];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(10,false);
def[5] = new BitArray(58,false);
def[6] = new BitArray(25,false);
def[7] = new BitArray(21,false);
def[8] = new BitArray(7,false);
def[9] = new BitArray(11,false);
def[10] = new BitArray(28,false);
def[11] = new BitArray(7,false);
def[12] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_acb134934352a9d72fd2cc0509d2f469> NewList() {
return new RL_c5ca0a80d78493d156f2b1a68d86a831();
}


} // RL_c5ca0a80d78493d156f2b1a68d86a831
}

