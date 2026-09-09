namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (h2fx7QroNUKYl3jlJopdsw)
///  <code>RC_79b8311427bcbe4ce4ecbe042bf03773</code> that represent
/// s <code>InvoiceExtendedCartaPorteRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedCartaPorteRecord
public partial struct RC_79b8311427bcbe4ce4ecbe042bf03773 : ITypedRecord<RC_79b8311427bcbe4ce4ecbe042bf03773> {
internal static readonly GlobalObjectKey IdInvoiceExtendedCartaPorte = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FDG4ebwnTL7k7L4EK_A3cw");

public EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte;


public static implicit operator EN_9bd576a05df3846c52ce88a606aff414EntityRecord( RC_79b8311427bcbe4ce4ecbe042bf03773 r) {
return r.ssENInvoiceExtendedCartaPorte;
}

public static implicit operator RC_79b8311427bcbe4ce4ecbe042bf03773 (EN_9bd576a05df3846c52ce88a606aff414EntityRecord r) {
RC_79b8311427bcbe4ce4ecbe042bf03773 res = new RC_79b8311427bcbe4ce4ecbe042bf03773 ();
res.ssENInvoiceExtendedCartaPorte = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedCartaPorte.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedCartaPorte.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_79b8311427bcbe4ce4ecbe042bf03773() {
OptimizedAttributes = null;
ssENInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedCartaPorte.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedCartaPorte.Read( r, ref index);
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
public void ReadIM(RC_79b8311427bcbe4ce4ecbe042bf03773 r) {
this = r;
}


public static bool operator == (RC_79b8311427bcbe4ce4ecbe042bf03773 a, RC_79b8311427bcbe4ce4ecbe042bf03773 b) {
if (a.ssENInvoiceExtendedCartaPorte != b.ssENInvoiceExtendedCartaPorte) return false;
return true;
}

public static bool operator != (RC_79b8311427bcbe4ce4ecbe042bf03773 a, RC_79b8311427bcbe4ce4ecbe042bf03773 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_79b8311427bcbe4ce4ecbe042bf03773)) return false;
return (this == (RC_79b8311427bcbe4ce4ecbe042bf03773)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedCartaPorte.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedCartaPorte.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedCartaPorte.InternalRecursiveSave();
}


public RC_79b8311427bcbe4ce4ecbe042bf03773 Duplicate() {
RC_79b8311427bcbe4ce4ecbe042bf03773 t;
t.ssENInvoiceExtendedCartaPorte = (EN_9bd576a05df3846c52ce88a606aff414EntityRecord)this.ssENInvoiceExtendedCartaPorte.Duplicate();
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
if (head == "invoiceextendedcartaporte") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedCartaPorte")) variable.Value = ssENInvoiceExtendedCartaPorte; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedcartaporte");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedCartaPorte.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedCartaPorte.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedCartaPorte) {
return ssENInvoiceExtendedCartaPorte;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedCartaPorte.Key.AsGuid) {
return ssENInvoiceExtendedCartaPorte;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedCartaPorte.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedCartaPorte));
}
} // RC_79b8311427bcbe4ce4ecbe042bf03773
/// <summary>
/// RecordList type <code>InvoiceExtendedCartaPorteRecordList</code> that represents a record list of
///  <code>InvoiceExtendedCartaPorte</code>
/// </summary>
public partial class RL_14eea858c7edac2969e2f91a68030ca7 : GenericRecordList<RC_79b8311427bcbe4ce4ecbe042bf03773>, IEnumerable, IEnumerator {

protected override RC_79b8311427bcbe4ce4ecbe042bf03773 GetElementDefaultValue() {
return new RC_79b8311427bcbe4ce4ecbe042bf03773();
}

public T[] ToArray<T>(Func<RC_79b8311427bcbe4ce4ecbe042bf03773, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_14eea858c7edac2969e2f91a68030ca7 recordList, Func<RC_79b8311427bcbe4ce4ecbe042bf03773, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_14eea858c7edac2969e2f91a68030ca7(RC_79b8311427bcbe4ce4ecbe042bf03773[] array) {
  RL_14eea858c7edac2969e2f91a68030ca7 result = new RL_14eea858c7edac2969e2f91a68030ca7();
result.InnerFromArray(array);
    return result;
}

public static RL_14eea858c7edac2969e2f91a68030ca7 ToList<T>(T[] array, Func <T, RC_79b8311427bcbe4ce4ecbe042bf03773> converter) {
  RL_14eea858c7edac2969e2f91a68030ca7 result = new RL_14eea858c7edac2969e2f91a68030ca7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_14eea858c7edac2969e2f91a68030ca7 FromRestList<T>(RestList<T> restList, Func <T, RC_79b8311427bcbe4ce4ecbe042bf03773> converter) {
  RL_14eea858c7edac2969e2f91a68030ca7 result = new RL_14eea858c7edac2969e2f91a68030ca7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_14eea858c7edac2969e2f91a68030ca7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_79b8311427bcbe4ce4ecbe042bf03773> NewList() {
return new RL_14eea858c7edac2969e2f91a68030ca7();
}


} // RL_14eea858c7edac2969e2f91a68030ca7
}

