namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoiceFilesAudit (Hf3SU9NjjkqgVzS1eFpR0Q)
///  <code>ST_29dc80a5deae2388e31181e1082143cfStructure</code> that represent
/// s <code>InvoiceFilesAudit</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFilesAudit
public partial struct ST_29dc80a5deae2388e31181e1082143cfStructure : ITypedRecord<ST_29dc80a5deae2388e31181e1082143cfStructure> {
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4soiVFQjXU+93RqxuxtMwA");
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iZKJq93FnU26Q5VpLqw_Zw");
internal static readonly GlobalObjectKey IdSupplierNr = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KuBKc5ALnEqEDsgtwHPuqA");
internal static readonly GlobalObjectKey IdInvoiceUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IT0f8reFvU68GrfnG8pgGQ");

public long ssInvoiceId;

public string ssInvoiceName;

public string ssSupplierNr;

public DateTime ssInvoiceUpdatedOn;


public BitArray OptimizedAttributes;

public ST_29dc80a5deae2388e31181e1082143cfStructure() {
OptimizedAttributes = null;
ssInvoiceId = 0L;
ssInvoiceName = "";
ssSupplierNr = "";
ssInvoiceUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFilesAudit.InvoiceId", 0L);
ssInvoiceName = r.ReadText(index++, "InvoiceFilesAudit.InvoiceName", "");
ssSupplierNr = r.ReadText(index++, "InvoiceFilesAudit.SupplierNr", "");
ssInvoiceUpdatedOn = r.ReadDateTime(index++, "InvoiceFilesAudit.InvoiceUpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_29dc80a5deae2388e31181e1082143cfStructure r) {
this = r;
}


public static bool operator == (ST_29dc80a5deae2388e31181e1082143cfStructure a, ST_29dc80a5deae2388e31181e1082143cfStructure b) {
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssSupplierNr != b.ssSupplierNr) return false;
if (a.ssInvoiceUpdatedOn != b.ssInvoiceUpdatedOn) return false;
return true;
}

public static bool operator != (ST_29dc80a5deae2388e31181e1082143cfStructure a, ST_29dc80a5deae2388e31181e1082143cfStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_29dc80a5deae2388e31181e1082143cfStructure)) return false;
return (this == (ST_29dc80a5deae2388e31181e1082143cfStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssSupplierNr.GetHashCode()
 ^ ssInvoiceUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_29dc80a5deae2388e31181e1082143cfStructure Duplicate() {
ST_29dc80a5deae2388e31181e1082143cfStructure t;
t.ssInvoiceId = this.ssInvoiceId;
t.ssInvoiceName = this.ssInvoiceName;
t.ssSupplierNr = this.ssSupplierNr;
t.ssInvoiceUpdatedOn = this.ssInvoiceUpdatedOn;
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
} else if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "suppliernr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNr")) variable.Value = ssSupplierNr; else variable.Optimized = true;
} else if (head == "invoiceupdatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUpdatedOn")) variable.Value = ssInvoiceUpdatedOn; else variable.Optimized = true;
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
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdSupplierNr) {
return ssSupplierNr;
}
if (key == IdInvoiceUpdatedOn) {
return ssInvoiceUpdatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdSupplierNr.Key.AsGuid) {
return ssSupplierNr;
}
if (attributeKey == IdInvoiceUpdatedOn.Key.AsGuid) {
return ssInvoiceUpdatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssSupplierNr = (string) other.AttributeGet(IdSupplierNr);
ssInvoiceUpdatedOn = (DateTime) other.AttributeGet(IdInvoiceUpdatedOn);
}
} // ST_29dc80a5deae2388e31181e1082143cfStructure
/// <summary>
/// RecordList type <code>InvoiceFilesAuditList</code> that represents a record list of
///  <code>InvoiceFilesAudit</code>
/// </summary>
public partial class RL_6da8ac1538224c0a012cd86c7222fe91 : GenericRecordList<ST_29dc80a5deae2388e31181e1082143cfStructure>, IEnumerable, IEnumerator {

protected override ST_29dc80a5deae2388e31181e1082143cfStructure GetElementDefaultValue() {
return new ST_29dc80a5deae2388e31181e1082143cfStructure();
}

public T[] ToArray<T>(Func<ST_29dc80a5deae2388e31181e1082143cfStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6da8ac1538224c0a012cd86c7222fe91 recordList, Func<ST_29dc80a5deae2388e31181e1082143cfStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6da8ac1538224c0a012cd86c7222fe91(ST_29dc80a5deae2388e31181e1082143cfStructure[] array) {
  RL_6da8ac1538224c0a012cd86c7222fe91 result = new RL_6da8ac1538224c0a012cd86c7222fe91();
result.InnerFromArray(array);
    return result;
}

public static RL_6da8ac1538224c0a012cd86c7222fe91 ToList<T>(T[] array, Func <T, ST_29dc80a5deae2388e31181e1082143cfStructure> converter) {
  RL_6da8ac1538224c0a012cd86c7222fe91 result = new RL_6da8ac1538224c0a012cd86c7222fe91();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6da8ac1538224c0a012cd86c7222fe91 FromRestList<T>(RestList<T> restList, Func <T, ST_29dc80a5deae2388e31181e1082143cfStructure> converter) {
  RL_6da8ac1538224c0a012cd86c7222fe91 result = new RL_6da8ac1538224c0a012cd86c7222fe91();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6da8ac1538224c0a012cd86c7222fe91() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_29dc80a5deae2388e31181e1082143cfStructure> NewList() {
return new RL_6da8ac1538224c0a012cd86c7222fe91();
}


} // RL_6da8ac1538224c0a012cd86c7222fe91
}

