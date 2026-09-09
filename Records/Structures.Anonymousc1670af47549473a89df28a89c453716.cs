namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9ApnwUl1OkeJ3yionEU3Fg)
///  <code>RC_88759af0096e690bb0b27652d93642e4</code> that represent
/// s <code>InvoiceAccountingProcessStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessStatusRecord
public partial struct RC_88759af0096e690bb0b27652d93642e4 : ITypedRecord<RC_88759af0096e690bb0b27652d93642e4> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8Jp1iG4JC2mwsnZS2TZC5A");

public EN_49cd884b6b005041992feafa8ecc46e0EntityRecord ssENInvoiceAccountingProcessStatus;


public static implicit operator EN_49cd884b6b005041992feafa8ecc46e0EntityRecord( RC_88759af0096e690bb0b27652d93642e4 r) {
return r.ssENInvoiceAccountingProcessStatus;
}

public static implicit operator RC_88759af0096e690bb0b27652d93642e4 (EN_49cd884b6b005041992feafa8ecc46e0EntityRecord r) {
RC_88759af0096e690bb0b27652d93642e4 res = new RC_88759af0096e690bb0b27652d93642e4 ();
res.ssENInvoiceAccountingProcessStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingProcessStatus.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingProcessStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_88759af0096e690bb0b27652d93642e4() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcessStatus = new EN_49cd884b6b005041992feafa8ecc46e0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcessStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingProcessStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingProcessStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingProcessStatus.Read( r, ref index);
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
public void ReadIM(RC_88759af0096e690bb0b27652d93642e4 r) {
this = r;
}


public static bool operator == (RC_88759af0096e690bb0b27652d93642e4 a, RC_88759af0096e690bb0b27652d93642e4 b) {
if (a.ssENInvoiceAccountingProcessStatus != b.ssENInvoiceAccountingProcessStatus) return false;
return true;
}

public static bool operator != (RC_88759af0096e690bb0b27652d93642e4 a, RC_88759af0096e690bb0b27652d93642e4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_88759af0096e690bb0b27652d93642e4)) return false;
return (this == (RC_88759af0096e690bb0b27652d93642e4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcessStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcessStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcessStatus.InternalRecursiveSave();
}


public RC_88759af0096e690bb0b27652d93642e4 Duplicate() {
RC_88759af0096e690bb0b27652d93642e4 t;
t.ssENInvoiceAccountingProcessStatus = (EN_49cd884b6b005041992feafa8ecc46e0EntityRecord)this.ssENInvoiceAccountingProcessStatus.Duplicate();
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
if (head == "invoiceaccountingprocessstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessStatus")) variable.Value = ssENInvoiceAccountingProcessStatus; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocessstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcessStatus) {
return ssENInvoiceAccountingProcessStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessStatus.Key.AsGuid) {
return ssENInvoiceAccountingProcessStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcessStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessStatus));
}
} // RC_88759af0096e690bb0b27652d93642e4
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessStatusRecordList</code> that represents a record list
///  of <code>InvoiceAccountingProcessStatus</code>
/// </summary>
public partial class RL_8104c01eb706b74a33652edf81b8c167 : GenericRecordList<RC_88759af0096e690bb0b27652d93642e4>, IEnumerable, IEnumerator {

protected override RC_88759af0096e690bb0b27652d93642e4 GetElementDefaultValue() {
return new RC_88759af0096e690bb0b27652d93642e4();
}

public T[] ToArray<T>(Func<RC_88759af0096e690bb0b27652d93642e4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8104c01eb706b74a33652edf81b8c167 recordList, Func<RC_88759af0096e690bb0b27652d93642e4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8104c01eb706b74a33652edf81b8c167(RC_88759af0096e690bb0b27652d93642e4[] array) {
  RL_8104c01eb706b74a33652edf81b8c167 result = new RL_8104c01eb706b74a33652edf81b8c167();
result.InnerFromArray(array);
    return result;
}

public static RL_8104c01eb706b74a33652edf81b8c167 ToList<T>(T[] array, Func <T, RC_88759af0096e690bb0b27652d93642e4> converter) {
  RL_8104c01eb706b74a33652edf81b8c167 result = new RL_8104c01eb706b74a33652edf81b8c167();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8104c01eb706b74a33652edf81b8c167 FromRestList<T>(RestList<T> restList, Func <T, RC_88759af0096e690bb0b27652d93642e4> converter) {
  RL_8104c01eb706b74a33652edf81b8c167 result = new RL_8104c01eb706b74a33652edf81b8c167();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8104c01eb706b74a33652edf81b8c167() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_88759af0096e690bb0b27652d93642e4> NewList() {
return new RL_8104c01eb706b74a33652edf81b8c167();
}


} // RL_8104c01eb706b74a33652edf81b8c167
}

