namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (H8e0P6P30kazpYPU5MDZPA)
///  <code>RC_56dd61ddd73c9e3bf07414aa1c617494</code> that represent
/// s <code>InvoiceAccountingProcessLines_F43Record</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessLines_F43Record
public partial struct RC_56dd61ddd73c9e3bf07414aa1c617494 : ITypedRecord<RC_56dd61ddd73c9e3bf07414aa1c617494> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessLines_F43 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3WHdVjzXO57wdBSqHGF0lA");

public EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord ssENInvoiceAccountingProcessLines_F43;


public static implicit operator EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord( RC_56dd61ddd73c9e3bf07414aa1c617494 r) {
return r.ssENInvoiceAccountingProcessLines_F43;
}

public static implicit operator RC_56dd61ddd73c9e3bf07414aa1c617494 (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord r) {
RC_56dd61ddd73c9e3bf07414aa1c617494 res = new RC_56dd61ddd73c9e3bf07414aa1c617494 ();
res.ssENInvoiceAccountingProcessLines_F43 = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingProcessLines_F43.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingProcessLines_F43.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_56dd61ddd73c9e3bf07414aa1c617494() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcessLines_F43 = new EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcessLines_F43.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingProcessLines_F43.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingProcessLines_F43.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingProcessLines_F43.Read( r, ref index);
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
public void ReadIM(RC_56dd61ddd73c9e3bf07414aa1c617494 r) {
this = r;
}


public static bool operator == (RC_56dd61ddd73c9e3bf07414aa1c617494 a, RC_56dd61ddd73c9e3bf07414aa1c617494 b) {
if (a.ssENInvoiceAccountingProcessLines_F43 != b.ssENInvoiceAccountingProcessLines_F43) return false;
return true;
}

public static bool operator != (RC_56dd61ddd73c9e3bf07414aa1c617494 a, RC_56dd61ddd73c9e3bf07414aa1c617494 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_56dd61ddd73c9e3bf07414aa1c617494)) return false;
return (this == (RC_56dd61ddd73c9e3bf07414aa1c617494)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcessLines_F43.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcessLines_F43.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcessLines_F43.InternalRecursiveSave();
}


public RC_56dd61ddd73c9e3bf07414aa1c617494 Duplicate() {
RC_56dd61ddd73c9e3bf07414aa1c617494 t;
t.ssENInvoiceAccountingProcessLines_F43 = (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord)this.ssENInvoiceAccountingProcessLines_F43.Duplicate();
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
if (head == "invoiceaccountingprocesslines_f43") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessLines_F43")) variable.Value = ssENInvoiceAccountingProcessLines_F43; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocesslines_f43");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessLines_F43.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessLines_F43.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcessLines_F43) {
return ssENInvoiceAccountingProcessLines_F43;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessLines_F43.Key.AsGuid) {
return ssENInvoiceAccountingProcessLines_F43;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcessLines_F43.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessLines_F43));
}
} // RC_56dd61ddd73c9e3bf07414aa1c617494
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessLines_F43RecordList</code> that represents a record
///  list of <code>InvoiceAccountingProcessLines_F43</code>
/// </summary>
public partial class RL_75a26b2df3c5e73743b57020e6939e68 : GenericRecordList<RC_56dd61ddd73c9e3bf07414aa1c617494>, IEnumerable, IEnumerator {

protected override RC_56dd61ddd73c9e3bf07414aa1c617494 GetElementDefaultValue() {
return new RC_56dd61ddd73c9e3bf07414aa1c617494();
}

public T[] ToArray<T>(Func<RC_56dd61ddd73c9e3bf07414aa1c617494, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_75a26b2df3c5e73743b57020e6939e68 recordList, Func<RC_56dd61ddd73c9e3bf07414aa1c617494, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_75a26b2df3c5e73743b57020e6939e68(RC_56dd61ddd73c9e3bf07414aa1c617494[] array) {
  RL_75a26b2df3c5e73743b57020e6939e68 result = new RL_75a26b2df3c5e73743b57020e6939e68();
result.InnerFromArray(array);
    return result;
}

public static RL_75a26b2df3c5e73743b57020e6939e68 ToList<T>(T[] array, Func <T, RC_56dd61ddd73c9e3bf07414aa1c617494> converter) {
  RL_75a26b2df3c5e73743b57020e6939e68 result = new RL_75a26b2df3c5e73743b57020e6939e68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_75a26b2df3c5e73743b57020e6939e68 FromRestList<T>(RestList<T> restList, Func <T, RC_56dd61ddd73c9e3bf07414aa1c617494> converter) {
  RL_75a26b2df3c5e73743b57020e6939e68 result = new RL_75a26b2df3c5e73743b57020e6939e68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_75a26b2df3c5e73743b57020e6939e68() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_56dd61ddd73c9e3bf07414aa1c617494> NewList() {
return new RL_75a26b2df3c5e73743b57020e6939e68();
}


} // RL_75a26b2df3c5e73743b57020e6939e68
}

