namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Wjy+XQ2GB0OcZbdaitKpLQ)
///  <code>RC_86423f353b6ff38800cf09bdbbb2131d</code> that represent
/// s
///  <code>CurrencyRequisitionRequisitionApprovalRequisitionStatusCompanySupplierCostCenterSAPProject_As
/// set_ServiceRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyRequisitionRequisitionApprovalRequisitionStatusCompanySupplierCostCenterSAPProject_Asset_ServiceRecord
public partial struct RC_86423f353b6ff38800cf09bdbbb2131d : ITypedRecord<RC_86423f353b6ff38800cf09bdbbb2131d> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdRequisitionStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2VyosKSDP_TsIKnpR3QQSw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord ssENRequisitionStatus;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;


public BitArray OptimizedAttributes;

public RC_86423f353b6ff38800cf09bdbbb2131d() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENRequisitionStatus = new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(11,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(25,false);
    all[7] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    ssENRequisitionStatus.OptimizedAttributes = value[3];
    ssENCompany.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENCostCenterSAP.OptimizedAttributes = value[6];
    ssENProject_Asset_Service.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionApproval.OptimizedAttributes;
    all[3] = ssENRequisitionStatus.OptimizedAttributes;
    all[4] = ssENCompany.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENCostCenterSAP.OptimizedAttributes;
    all[7] = ssENProject_Asset_Service.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
ssENRequisitionStatus.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
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
public void ReadIM(RC_86423f353b6ff38800cf09bdbbb2131d r) {
this = r;
}


public static bool operator == (RC_86423f353b6ff38800cf09bdbbb2131d a, RC_86423f353b6ff38800cf09bdbbb2131d b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENRequisitionStatus != b.ssENRequisitionStatus) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
return true;
}

public static bool operator != (RC_86423f353b6ff38800cf09bdbbb2131d a, RC_86423f353b6ff38800cf09bdbbb2131d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_86423f353b6ff38800cf09bdbbb2131d)) return false;
return (this == (RC_86423f353b6ff38800cf09bdbbb2131d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENRequisitionStatus.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENRequisitionStatus.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENRequisitionStatus.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
}


public RC_86423f353b6ff38800cf09bdbbb2131d Duplicate() {
RC_86423f353b6ff38800cf09bdbbb2131d t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
t.ssENRequisitionStatus = (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)this.ssENRequisitionStatus.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
} else if (head == "requisitionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatus")) variable.Value = ssENRequisitionStatus; else variable.Optimized = true;
variable.SetFieldName("requisitionstatus");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
if (key == IdRequisitionStatus) {
return ssENRequisitionStatus;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdRequisitionStatus.Key.AsGuid) {
return ssENRequisitionStatus;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENRequisitionStatus.FillFromOther((IRecord) other.AttributeGet(IdRequisitionStatus));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
}
} // RC_86423f353b6ff38800cf09bdbbb2131d
/// <summary>
/// RecordList type
///  <code>CurrencyRequisitionRequisitionApprovalRequisitionStatusCompanySupplierCostCenterSAPProject_As
/// set_ServiceRecordList</code> that represents a record list of <code>Currency, Requisition,
///  RequisitionApproval, RequisitionStatus, Company, Supplier, CostCenterSAP
/// , Project_Asset_Service</code>
/// </summary>
public partial class RL_39c5627b3bb44cc40b890ccd9b2786b2 : GenericRecordList<RC_86423f353b6ff38800cf09bdbbb2131d>, IEnumerable, IEnumerator {

protected override RC_86423f353b6ff38800cf09bdbbb2131d GetElementDefaultValue() {
return new RC_86423f353b6ff38800cf09bdbbb2131d();
}

public T[] ToArray<T>(Func<RC_86423f353b6ff38800cf09bdbbb2131d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39c5627b3bb44cc40b890ccd9b2786b2 recordList, Func<RC_86423f353b6ff38800cf09bdbbb2131d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39c5627b3bb44cc40b890ccd9b2786b2(RC_86423f353b6ff38800cf09bdbbb2131d[] array) {
  RL_39c5627b3bb44cc40b890ccd9b2786b2 result = new RL_39c5627b3bb44cc40b890ccd9b2786b2();
result.InnerFromArray(array);
    return result;
}

public static RL_39c5627b3bb44cc40b890ccd9b2786b2 ToList<T>(T[] array, Func <T, RC_86423f353b6ff38800cf09bdbbb2131d> converter) {
  RL_39c5627b3bb44cc40b890ccd9b2786b2 result = new RL_39c5627b3bb44cc40b890ccd9b2786b2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39c5627b3bb44cc40b890ccd9b2786b2 FromRestList<T>(RestList<T> restList, Func <T, RC_86423f353b6ff38800cf09bdbbb2131d> converter) {
  RL_39c5627b3bb44cc40b890ccd9b2786b2 result = new RL_39c5627b3bb44cc40b890ccd9b2786b2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39c5627b3bb44cc40b890ccd9b2786b2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(11,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(25,false);
def[7] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_86423f353b6ff38800cf09bdbbb2131d> NewList() {
return new RL_39c5627b3bb44cc40b890ccd9b2786b2();
}


} // RL_39c5627b3bb44cc40b890ccd9b2786b2
}

