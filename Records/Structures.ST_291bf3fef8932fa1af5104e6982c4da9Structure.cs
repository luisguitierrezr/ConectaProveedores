namespace ssConectaProveedores {
/// <summary>
/// [Structure] RequisitionsListInternalTableStructure (zNUusB33J0aAmrOwEMQWrA)
///  <code>ST_291bf3fef8932fa1af5104e6982c4da9Structure</code> that represent
/// s <code>RequisitionsListInternalTableStructure</code> <p>Description: </p>
/// </summary>
// Name: RequisitionsListInternalTableStructure
public partial struct ST_291bf3fef8932fa1af5104e6982c4da9Structure : ITypedRecord<ST_291bf3fef8932fa1af5104e6982c4da9Structure> {
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*stEjRGQvk0+31xHcBIEjuA");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P4J7c5c5wkaE6zHADTGCmA");
internal static readonly GlobalObjectKey IdRequisitionName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gJ_ZuMSdfE+nsrLFBlo7gQ");
internal static readonly GlobalObjectKey IdRequisitionStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C0_TKiq9RUO6TssYg7o41w");
internal static readonly GlobalObjectKey IdCreationDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3wDcWFDI6U6K3LBdoFps8g");
internal static readonly GlobalObjectKey IdLastChange = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*03P+PQasyEGNOT5IT_UwUA");
internal static readonly GlobalObjectKey IdRequester = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nM_2YHOK9kOE19YHjcRkSQ");
internal static readonly GlobalObjectKey IdProject = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7ZPM4FOBRUWXH+XLGluKAg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mQIddhZ5D0mUgHuo3Tq2GA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PthriUszFEWvmLzcwjGnMA");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JLDuxlvJrkaN4DoCSFvzsA");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*glOCUpGoU02zXv8d+GADjA");
internal static readonly GlobalObjectKey IdCostCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oPyq5XZul0StAfxEelv1vg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wP0Ss0RnXEybrWC0OCoTig");
internal static readonly GlobalObjectKey IdLastApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VNbgHPrBZk251q3hGINy+Q");
internal static readonly GlobalObjectKey IdLastApproverApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Lm8F+O9ZsUeliTWZSfzcWg");
internal static readonly GlobalObjectKey IdPolizaSAP_SentWhen = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*V7moA4MAUUSEI+X99lQgjw");
internal static readonly GlobalObjectKey IdAction = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Rd5LWoDwYUePcc7+D0kCaA");

public long ssRequisitionId;

public long ssRequisitionApprovalLevelId;

public string ssRequisitionName;

public string ssRequisitionStatus;

public string ssCreationDate;

public string ssLastChange;

public string ssRequester;

public string ssProject;

public string ssSupplier;

public string ssRegion;

public string ssAmount;

public string ssCurrency;

public string ssCostCenter;

public string ssCompany;

public string ssLastApprover;

public string ssLastApproverApprovedOn;

public string ssPolizaSAP_SentWhen;

public string ssAction;


public BitArray OptimizedAttributes;

public ST_291bf3fef8932fa1af5104e6982c4da9Structure() {
OptimizedAttributes = null;
ssRequisitionId = 0L;
ssRequisitionApprovalLevelId = 0L;
ssRequisitionName = "";
ssRequisitionStatus = "";
ssCreationDate = "";
ssLastChange = "";
ssRequester = "";
ssProject = "";
ssSupplier = "";
ssRegion = "";
ssAmount = "";
ssCurrency = "";
ssCostCenter = "";
ssCompany = "";
ssLastApprover = "";
ssLastApproverApprovedOn = "";
ssPolizaSAP_SentWhen = "";
ssAction = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionsListInternalTableStructure.RequisitionId", 0L);
ssRequisitionApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "RequisitionsListInternalTableStructure.RequisitionApprovalLevelId", 0L);
ssRequisitionName = r.ReadText(index++, "RequisitionsListInternalTableStructure.RequisitionName", "");
ssRequisitionStatus = r.ReadText(index++, "RequisitionsListInternalTableStructure.RequisitionStatus", "");
ssCreationDate = r.ReadText(index++, "RequisitionsListInternalTableStructure.CreationDate", "");
ssLastChange = r.ReadText(index++, "RequisitionsListInternalTableStructure.LastChange", "");
ssRequester = r.ReadText(index++, "RequisitionsListInternalTableStructure.Requester", "");
ssProject = r.ReadText(index++, "RequisitionsListInternalTableStructure.Project", "");
ssSupplier = r.ReadText(index++, "RequisitionsListInternalTableStructure.Supplier", "");
ssRegion = r.ReadText(index++, "RequisitionsListInternalTableStructure.Region", "");
ssAmount = r.ReadText(index++, "RequisitionsListInternalTableStructure.Amount", "");
ssCurrency = r.ReadText(index++, "RequisitionsListInternalTableStructure.Currency", "");
ssCostCenter = r.ReadText(index++, "RequisitionsListInternalTableStructure.CostCenter", "");
ssCompany = r.ReadText(index++, "RequisitionsListInternalTableStructure.Company", "");
ssLastApprover = r.ReadText(index++, "RequisitionsListInternalTableStructure.LastApprover", "");
ssLastApproverApprovedOn = r.ReadText(index++, "RequisitionsListInternalTableStructure.LastApproverApprovedOn", "");
ssPolizaSAP_SentWhen = r.ReadText(index++, "RequisitionsListInternalTableStructure.PolizaSAP_SentWhen", "");
ssAction = r.ReadText(index++, "RequisitionsListInternalTableStructure.Action", "");
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
public void ReadIM(ST_291bf3fef8932fa1af5104e6982c4da9Structure r) {
this = r;
}


public static bool operator == (ST_291bf3fef8932fa1af5104e6982c4da9Structure a, ST_291bf3fef8932fa1af5104e6982c4da9Structure b) {
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionApprovalLevelId != b.ssRequisitionApprovalLevelId) return false;
if (a.ssRequisitionName != b.ssRequisitionName) return false;
if (a.ssRequisitionStatus != b.ssRequisitionStatus) return false;
if (a.ssCreationDate != b.ssCreationDate) return false;
if (a.ssLastChange != b.ssLastChange) return false;
if (a.ssRequester != b.ssRequester) return false;
if (a.ssProject != b.ssProject) return false;
if (a.ssSupplier != b.ssSupplier) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssCostCenter != b.ssCostCenter) return false;
if (a.ssCompany != b.ssCompany) return false;
if (a.ssLastApprover != b.ssLastApprover) return false;
if (a.ssLastApproverApprovedOn != b.ssLastApproverApprovedOn) return false;
if (a.ssPolizaSAP_SentWhen != b.ssPolizaSAP_SentWhen) return false;
if (a.ssAction != b.ssAction) return false;
return true;
}

public static bool operator != (ST_291bf3fef8932fa1af5104e6982c4da9Structure a, ST_291bf3fef8932fa1af5104e6982c4da9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_291bf3fef8932fa1af5104e6982c4da9Structure)) return false;
return (this == (ST_291bf3fef8932fa1af5104e6982c4da9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionApprovalLevelId.GetHashCode()
 ^ ssRequisitionName.GetHashCode()
 ^ ssRequisitionStatus.GetHashCode()
 ^ ssCreationDate.GetHashCode()
 ^ ssLastChange.GetHashCode()
 ^ ssRequester.GetHashCode()
 ^ ssProject.GetHashCode()
 ^ ssSupplier.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssCostCenter.GetHashCode()
 ^ ssCompany.GetHashCode()
 ^ ssLastApprover.GetHashCode()
 ^ ssLastApproverApprovedOn.GetHashCode()
 ^ ssPolizaSAP_SentWhen.GetHashCode()
 ^ ssAction.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_291bf3fef8932fa1af5104e6982c4da9Structure Duplicate() {
ST_291bf3fef8932fa1af5104e6982c4da9Structure t;
t.ssRequisitionId = this.ssRequisitionId;
t.ssRequisitionApprovalLevelId = this.ssRequisitionApprovalLevelId;
t.ssRequisitionName = this.ssRequisitionName;
t.ssRequisitionStatus = this.ssRequisitionStatus;
t.ssCreationDate = this.ssCreationDate;
t.ssLastChange = this.ssLastChange;
t.ssRequester = this.ssRequester;
t.ssProject = this.ssProject;
t.ssSupplier = this.ssSupplier;
t.ssRegion = this.ssRegion;
t.ssAmount = this.ssAmount;
t.ssCurrency = this.ssCurrency;
t.ssCostCenter = this.ssCostCenter;
t.ssCompany = this.ssCompany;
t.ssLastApprover = this.ssLastApprover;
t.ssLastApproverApprovedOn = this.ssLastApproverApprovedOn;
t.ssPolizaSAP_SentWhen = this.ssPolizaSAP_SentWhen;
t.ssAction = this.ssAction;
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
if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "requisitionapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevelId")) variable.Value = ssRequisitionApprovalLevelId; else variable.Optimized = true;
} else if (head == "requisitionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionName")) variable.Value = ssRequisitionName; else variable.Optimized = true;
} else if (head == "requisitionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatus")) variable.Value = ssRequisitionStatus; else variable.Optimized = true;
} else if (head == "creationdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreationDate")) variable.Value = ssCreationDate; else variable.Optimized = true;
} else if (head == "lastchange") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastChange")) variable.Value = ssLastChange; else variable.Optimized = true;
} else if (head == "requester") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requester")) variable.Value = ssRequester; else variable.Optimized = true;
} else if (head == "project") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project")) variable.Value = ssProject; else variable.Optimized = true;
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssSupplier; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "costcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenter")) variable.Value = ssCostCenter; else variable.Optimized = true;
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssCompany; else variable.Optimized = true;
} else if (head == "lastapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApprover")) variable.Value = ssLastApprover; else variable.Optimized = true;
} else if (head == "lastapproverapprovedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApproverApprovedOn")) variable.Value = ssLastApproverApprovedOn; else variable.Optimized = true;
} else if (head == "polizasap_sentwhen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PolizaSAP_SentWhen")) variable.Value = ssPolizaSAP_SentWhen; else variable.Optimized = true;
} else if (head == "action") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Action")) variable.Value = ssAction; else variable.Optimized = true;
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
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdRequisitionApprovalLevelId) {
return ssRequisitionApprovalLevelId;
}
if (key == IdRequisitionName) {
return ssRequisitionName;
}
if (key == IdRequisitionStatus) {
return ssRequisitionStatus;
}
if (key == IdCreationDate) {
return ssCreationDate;
}
if (key == IdLastChange) {
return ssLastChange;
}
if (key == IdRequester) {
return ssRequester;
}
if (key == IdProject) {
return ssProject;
}
if (key == IdSupplier) {
return ssSupplier;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdCostCenter) {
return ssCostCenter;
}
if (key == IdCompany) {
return ssCompany;
}
if (key == IdLastApprover) {
return ssLastApprover;
}
if (key == IdLastApproverApprovedOn) {
return ssLastApproverApprovedOn;
}
if (key == IdPolizaSAP_SentWhen) {
return ssPolizaSAP_SentWhen;
}
if (key == IdAction) {
return ssAction;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdRequisitionApprovalLevelId.Key.AsGuid) {
return ssRequisitionApprovalLevelId;
}
if (attributeKey == IdRequisitionName.Key.AsGuid) {
return ssRequisitionName;
}
if (attributeKey == IdRequisitionStatus.Key.AsGuid) {
return ssRequisitionStatus;
}
if (attributeKey == IdCreationDate.Key.AsGuid) {
return ssCreationDate;
}
if (attributeKey == IdLastChange.Key.AsGuid) {
return ssLastChange;
}
if (attributeKey == IdRequester.Key.AsGuid) {
return ssRequester;
}
if (attributeKey == IdProject.Key.AsGuid) {
return ssProject;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdCostCenter.Key.AsGuid) {
return ssCostCenter;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssCompany;
}
if (attributeKey == IdLastApprover.Key.AsGuid) {
return ssLastApprover;
}
if (attributeKey == IdLastApproverApprovedOn.Key.AsGuid) {
return ssLastApproverApprovedOn;
}
if (attributeKey == IdPolizaSAP_SentWhen.Key.AsGuid) {
return ssPolizaSAP_SentWhen;
}
if (attributeKey == IdAction.Key.AsGuid) {
return ssAction;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ssRequisitionApprovalLevelId = (long) other.AttributeGet(IdRequisitionApprovalLevelId);
ssRequisitionName = (string) other.AttributeGet(IdRequisitionName);
ssRequisitionStatus = (string) other.AttributeGet(IdRequisitionStatus);
ssCreationDate = (string) other.AttributeGet(IdCreationDate);
ssLastChange = (string) other.AttributeGet(IdLastChange);
ssRequester = (string) other.AttributeGet(IdRequester);
ssProject = (string) other.AttributeGet(IdProject);
ssSupplier = (string) other.AttributeGet(IdSupplier);
ssRegion = (string) other.AttributeGet(IdRegion);
ssAmount = (string) other.AttributeGet(IdAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssCostCenter = (string) other.AttributeGet(IdCostCenter);
ssCompany = (string) other.AttributeGet(IdCompany);
ssLastApprover = (string) other.AttributeGet(IdLastApprover);
ssLastApproverApprovedOn = (string) other.AttributeGet(IdLastApproverApprovedOn);
ssPolizaSAP_SentWhen = (string) other.AttributeGet(IdPolizaSAP_SentWhen);
ssAction = (string) other.AttributeGet(IdAction);
}
} // ST_291bf3fef8932fa1af5104e6982c4da9Structure
/// <summary>
/// RecordList type <code>RequisitionsListInternalTableStructureList</code> that represents a record
///  list of <code>RequisitionsListInternalTableStructure</code>
/// </summary>
public partial class RL_622bdef78070a83f1d39501965da2144 : GenericRecordList<ST_291bf3fef8932fa1af5104e6982c4da9Structure>, IEnumerable, IEnumerator {

protected override ST_291bf3fef8932fa1af5104e6982c4da9Structure GetElementDefaultValue() {
return new ST_291bf3fef8932fa1af5104e6982c4da9Structure();
}

public T[] ToArray<T>(Func<ST_291bf3fef8932fa1af5104e6982c4da9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_622bdef78070a83f1d39501965da2144 recordList, Func<ST_291bf3fef8932fa1af5104e6982c4da9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_622bdef78070a83f1d39501965da2144(ST_291bf3fef8932fa1af5104e6982c4da9Structure[] array) {
  RL_622bdef78070a83f1d39501965da2144 result = new RL_622bdef78070a83f1d39501965da2144();
result.InnerFromArray(array);
    return result;
}

public static RL_622bdef78070a83f1d39501965da2144 ToList<T>(T[] array, Func <T, ST_291bf3fef8932fa1af5104e6982c4da9Structure> converter) {
  RL_622bdef78070a83f1d39501965da2144 result = new RL_622bdef78070a83f1d39501965da2144();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_622bdef78070a83f1d39501965da2144 FromRestList<T>(RestList<T> restList, Func <T, ST_291bf3fef8932fa1af5104e6982c4da9Structure> converter) {
  RL_622bdef78070a83f1d39501965da2144 result = new RL_622bdef78070a83f1d39501965da2144();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_622bdef78070a83f1d39501965da2144() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_291bf3fef8932fa1af5104e6982c4da9Structure> NewList() {
return new RL_622bdef78070a83f1d39501965da2144();
}


} // RL_622bdef78070a83f1d39501965da2144
}

