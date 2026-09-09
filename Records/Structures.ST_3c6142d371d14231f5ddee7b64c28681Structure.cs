namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoicesScreenTableStructure (WZLGVeWVD0yFKRbb6H3HWw)
///  <code>ST_3c6142d371d14231f5ddee7b64c28681Structure</code> that represent
/// s <code>InvoicesScreenTableStructure</code> <p>Description: </p>
/// </summary>
// Name: InvoicesScreenTableStructure
public partial struct ST_3c6142d371d14231f5ddee7b64c28681Structure : ITypedRecord<ST_3c6142d371d14231f5ddee7b64c28681Structure> {
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hdySlg0MS0GwqjWMZdrMuQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q9pCFDbWEUupJoS__yAFqQ");
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LCIVg0wFK0qvuOW2kvs9tg");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*08+I4JnKoUmk5EHJ2SSrCA");
internal static readonly GlobalObjectKey IdRequisitionName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*G5pvB2yHhEWC72kZv8LmYQ");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cfgvN80vF02lEwyZJLYpXw");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BvQC3qj020yWBTKm6RZxeg");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6FbkDs4VqkeChARAhaRrXw");
internal static readonly GlobalObjectKey IdUploadDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*91L9ncWQ0kiigksVI66Ftw");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hp2VylyzlE22Dv1hOLgP5g");
internal static readonly GlobalObjectKey IdAction = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KbqSXE50j0Gl6lkWp_T25Q");

public long ssInvoiceId;

public long ssInvoiceApprovalLevelId;

public string ssInvoiceName;

public string ssInvoiceStatus;

public string ssRequisitionName;

public string ssSupplierName;

public string ssSupplierNumber;

public string ssTotalAmount;

public string ssUploadDate;

public string ssAssignedTo;

public string ssAction;


public BitArray OptimizedAttributes;

public ST_3c6142d371d14231f5ddee7b64c28681Structure() {
OptimizedAttributes = null;
ssInvoiceId = 0L;
ssInvoiceApprovalLevelId = 0L;
ssInvoiceName = "";
ssInvoiceStatus = "";
ssRequisitionName = "";
ssSupplierName = "";
ssSupplierNumber = "";
ssTotalAmount = "";
ssUploadDate = "";
ssAssignedTo = "";
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
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoicesScreenTableStructure.InvoiceId", 0L);
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoicesScreenTableStructure.InvoiceApprovalLevelId", 0L);
ssInvoiceName = r.ReadText(index++, "InvoicesScreenTableStructure.InvoiceName", "");
ssInvoiceStatus = r.ReadText(index++, "InvoicesScreenTableStructure.InvoiceStatus", "");
ssRequisitionName = r.ReadText(index++, "InvoicesScreenTableStructure.RequisitionName", "");
ssSupplierName = r.ReadText(index++, "InvoicesScreenTableStructure.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "InvoicesScreenTableStructure.SupplierNumber", "");
ssTotalAmount = r.ReadText(index++, "InvoicesScreenTableStructure.TotalAmount", "");
ssUploadDate = r.ReadText(index++, "InvoicesScreenTableStructure.UploadDate", "");
ssAssignedTo = r.ReadText(index++, "InvoicesScreenTableStructure.AssignedTo", "");
ssAction = r.ReadText(index++, "InvoicesScreenTableStructure.Action", "");
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
public void ReadIM(ST_3c6142d371d14231f5ddee7b64c28681Structure r) {
this = r;
}


public static bool operator == (ST_3c6142d371d14231f5ddee7b64c28681Structure a, ST_3c6142d371d14231f5ddee7b64c28681Structure b) {
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssInvoiceStatus != b.ssInvoiceStatus) return false;
if (a.ssRequisitionName != b.ssRequisitionName) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssUploadDate != b.ssUploadDate) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssAction != b.ssAction) return false;
return true;
}

public static bool operator != (ST_3c6142d371d14231f5ddee7b64c28681Structure a, ST_3c6142d371d14231f5ddee7b64c28681Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3c6142d371d14231f5ddee7b64c28681Structure)) return false;
return (this == (ST_3c6142d371d14231f5ddee7b64c28681Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssInvoiceStatus.GetHashCode()
 ^ ssRequisitionName.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssUploadDate.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
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


public ST_3c6142d371d14231f5ddee7b64c28681Structure Duplicate() {
ST_3c6142d371d14231f5ddee7b64c28681Structure t;
t.ssInvoiceId = this.ssInvoiceId;
t.ssInvoiceApprovalLevelId = this.ssInvoiceApprovalLevelId;
t.ssInvoiceName = this.ssInvoiceName;
t.ssInvoiceStatus = this.ssInvoiceStatus;
t.ssRequisitionName = this.ssRequisitionName;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssTotalAmount = this.ssTotalAmount;
t.ssUploadDate = this.ssUploadDate;
t.ssAssignedTo = this.ssAssignedTo;
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
if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssInvoiceStatus; else variable.Optimized = true;
} else if (head == "requisitionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionName")) variable.Value = ssRequisitionName; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "uploaddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadDate")) variable.Value = ssUploadDate; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
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
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdInvoiceStatus) {
return ssInvoiceStatus;
}
if (key == IdRequisitionName) {
return ssRequisitionName;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdUploadDate) {
return ssUploadDate;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
}
if (key == IdAction) {
return ssAction;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssInvoiceStatus;
}
if (attributeKey == IdRequisitionName.Key.AsGuid) {
return ssRequisitionName;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdUploadDate.Key.AsGuid) {
return ssUploadDate;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
}
if (attributeKey == IdAction.Key.AsGuid) {
return ssAction;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssInvoiceStatus = (string) other.AttributeGet(IdInvoiceStatus);
ssRequisitionName = (string) other.AttributeGet(IdRequisitionName);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
ssUploadDate = (string) other.AttributeGet(IdUploadDate);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ssAction = (string) other.AttributeGet(IdAction);
}
} // ST_3c6142d371d14231f5ddee7b64c28681Structure
/// <summary>
/// RecordList type <code>InvoicesScreenTableStructureList</code> that represents a record list of
///  <code>InvoicesScreenTableStructure</code>
/// </summary>
public partial class RL_77750b395266828bf78fae563dd1fc3f : GenericRecordList<ST_3c6142d371d14231f5ddee7b64c28681Structure>, IEnumerable, IEnumerator {

protected override ST_3c6142d371d14231f5ddee7b64c28681Structure GetElementDefaultValue() {
return new ST_3c6142d371d14231f5ddee7b64c28681Structure();
}

public T[] ToArray<T>(Func<ST_3c6142d371d14231f5ddee7b64c28681Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_77750b395266828bf78fae563dd1fc3f recordList, Func<ST_3c6142d371d14231f5ddee7b64c28681Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_77750b395266828bf78fae563dd1fc3f(ST_3c6142d371d14231f5ddee7b64c28681Structure[] array) {
  RL_77750b395266828bf78fae563dd1fc3f result = new RL_77750b395266828bf78fae563dd1fc3f();
result.InnerFromArray(array);
    return result;
}

public static RL_77750b395266828bf78fae563dd1fc3f ToList<T>(T[] array, Func <T, ST_3c6142d371d14231f5ddee7b64c28681Structure> converter) {
  RL_77750b395266828bf78fae563dd1fc3f result = new RL_77750b395266828bf78fae563dd1fc3f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_77750b395266828bf78fae563dd1fc3f FromRestList<T>(RestList<T> restList, Func <T, ST_3c6142d371d14231f5ddee7b64c28681Structure> converter) {
  RL_77750b395266828bf78fae563dd1fc3f result = new RL_77750b395266828bf78fae563dd1fc3f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_77750b395266828bf78fae563dd1fc3f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3c6142d371d14231f5ddee7b64c28681Structure> NewList() {
return new RL_77750b395266828bf78fae563dd1fc3f();
}


} // RL_77750b395266828bf78fae563dd1fc3f
}

