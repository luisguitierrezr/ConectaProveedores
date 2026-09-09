namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BOnLm3llBEOv0gzh51C5kA)
///  <code>RC_fbe3f1050ad4f34fa0e0a15f88a56873</code> that represents <code>InvoiceExtendedRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedRecord
public partial struct RC_fbe3f1050ad4f34fa0e0a15f88a56873 : ITypedRecord<RC_fbe3f1050ad4f34fa0e0a15f88a56873> {
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public static implicit operator EN_f81a3d226103fd013068b8763798067aEntityRecord( RC_fbe3f1050ad4f34fa0e0a15f88a56873 r) {
return r.ssENInvoiceExtended;
}

public static implicit operator RC_fbe3f1050ad4f34fa0e0a15f88a56873 (EN_f81a3d226103fd013068b8763798067aEntityRecord r) {
RC_fbe3f1050ad4f34fa0e0a15f88a56873 res = new RC_fbe3f1050ad4f34fa0e0a15f88a56873 ();
res.ssENInvoiceExtended = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtended.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtended.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fbe3f1050ad4f34fa0e0a15f88a56873() {
OptimizedAttributes = null;
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtended.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtended.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtended.Read( r, ref index);
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
public void ReadIM(RC_fbe3f1050ad4f34fa0e0a15f88a56873 r) {
this = r;
}


public static bool operator == (RC_fbe3f1050ad4f34fa0e0a15f88a56873 a, RC_fbe3f1050ad4f34fa0e0a15f88a56873 b) {
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_fbe3f1050ad4f34fa0e0a15f88a56873 a, RC_fbe3f1050ad4f34fa0e0a15f88a56873 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fbe3f1050ad4f34fa0e0a15f88a56873)) return false;
return (this == (RC_fbe3f1050ad4f34fa0e0a15f88a56873)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_fbe3f1050ad4f34fa0e0a15f88a56873 Duplicate() {
RC_fbe3f1050ad4f34fa0e0a15f88a56873 t;
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
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
if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtended.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtended.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_fbe3f1050ad4f34fa0e0a15f88a56873
/// <summary>
/// RecordList type <code>InvoiceExtendedRecordList</code> that represents a record list of
///  <code>InvoiceExtended</code>
/// </summary>
public partial class RL_a675a81d4063c2bba451ee57edc49e99 : GenericRecordList<RC_fbe3f1050ad4f34fa0e0a15f88a56873>, IEnumerable, IEnumerator {

protected override RC_fbe3f1050ad4f34fa0e0a15f88a56873 GetElementDefaultValue() {
return new RC_fbe3f1050ad4f34fa0e0a15f88a56873();
}

public T[] ToArray<T>(Func<RC_fbe3f1050ad4f34fa0e0a15f88a56873, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a675a81d4063c2bba451ee57edc49e99 recordList, Func<RC_fbe3f1050ad4f34fa0e0a15f88a56873, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a675a81d4063c2bba451ee57edc49e99(RC_fbe3f1050ad4f34fa0e0a15f88a56873[] array) {
  RL_a675a81d4063c2bba451ee57edc49e99 result = new RL_a675a81d4063c2bba451ee57edc49e99();
result.InnerFromArray(array);
    return result;
}

public static RL_a675a81d4063c2bba451ee57edc49e99 ToList<T>(T[] array, Func <T, RC_fbe3f1050ad4f34fa0e0a15f88a56873> converter) {
  RL_a675a81d4063c2bba451ee57edc49e99 result = new RL_a675a81d4063c2bba451ee57edc49e99();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a675a81d4063c2bba451ee57edc49e99 FromRestList<T>(RestList<T> restList, Func <T, RC_fbe3f1050ad4f34fa0e0a15f88a56873> converter) {
  RL_a675a81d4063c2bba451ee57edc49e99 result = new RL_a675a81d4063c2bba451ee57edc49e99();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a675a81d4063c2bba451ee57edc49e99() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fbe3f1050ad4f34fa0e0a15f88a56873> NewList() {
return new RL_a675a81d4063c2bba451ee57edc49e99();
}


} // RL_a675a81d4063c2bba451ee57edc49e99
}

