namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+in_R929akmrvMPmpm_GXA)
///  <code>RC_04c5986b32c7822f033c933cf71b96bd</code> that represents <code>InvoiceRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceRecord
public partial struct RC_04c5986b32c7822f033c933cf71b96bd : ITypedRecord<RC_04c5986b32c7822f033c933cf71b96bd> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;


public static implicit operator EN_d1d0320db36efbb094ad0082361435a0EntityRecord( RC_04c5986b32c7822f033c933cf71b96bd r) {
return r.ssENInvoice;
}

public static implicit operator RC_04c5986b32c7822f033c933cf71b96bd (EN_d1d0320db36efbb094ad0082361435a0EntityRecord r) {
RC_04c5986b32c7822f033c933cf71b96bd res = new RC_04c5986b32c7822f033c933cf71b96bd ();
res.ssENInvoice = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoice.ChangedAttributes = value;
}
get {
    return ssENInvoice.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_04c5986b32c7822f033c933cf71b96bd() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(24,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoice.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
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
public void ReadIM(RC_04c5986b32c7822f033c933cf71b96bd r) {
this = r;
}


public static bool operator == (RC_04c5986b32c7822f033c933cf71b96bd a, RC_04c5986b32c7822f033c933cf71b96bd b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
return true;
}

public static bool operator != (RC_04c5986b32c7822f033c933cf71b96bd a, RC_04c5986b32c7822f033c933cf71b96bd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_04c5986b32c7822f033c933cf71b96bd)) return false;
return (this == (RC_04c5986b32c7822f033c933cf71b96bd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
}


public RC_04c5986b32c7822f033c933cf71b96bd Duplicate() {
RC_04c5986b32c7822f033c933cf71b96bd t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoice.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoice.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoice) {
return ssENInvoice;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
}
} // RC_04c5986b32c7822f033c933cf71b96bd
/// <summary>
/// RecordList type <code>InvoiceRecordList</code> that represents a record list of
///  <code>Invoice</code>
/// </summary>
public partial class RL_7b3475883ca90ad6eb7fc983e868c456 : GenericRecordList<RC_04c5986b32c7822f033c933cf71b96bd>, IEnumerable, IEnumerator {

protected override RC_04c5986b32c7822f033c933cf71b96bd GetElementDefaultValue() {
return new RC_04c5986b32c7822f033c933cf71b96bd();
}

public T[] ToArray<T>(Func<RC_04c5986b32c7822f033c933cf71b96bd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b3475883ca90ad6eb7fc983e868c456 recordList, Func<RC_04c5986b32c7822f033c933cf71b96bd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b3475883ca90ad6eb7fc983e868c456(RC_04c5986b32c7822f033c933cf71b96bd[] array) {
  RL_7b3475883ca90ad6eb7fc983e868c456 result = new RL_7b3475883ca90ad6eb7fc983e868c456();
result.InnerFromArray(array);
    return result;
}

public static RL_7b3475883ca90ad6eb7fc983e868c456 ToList<T>(T[] array, Func <T, RC_04c5986b32c7822f033c933cf71b96bd> converter) {
  RL_7b3475883ca90ad6eb7fc983e868c456 result = new RL_7b3475883ca90ad6eb7fc983e868c456();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b3475883ca90ad6eb7fc983e868c456 FromRestList<T>(RestList<T> restList, Func <T, RC_04c5986b32c7822f033c933cf71b96bd> converter) {
  RL_7b3475883ca90ad6eb7fc983e868c456 result = new RL_7b3475883ca90ad6eb7fc983e868c456();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b3475883ca90ad6eb7fc983e868c456() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(24,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_04c5986b32c7822f033c933cf71b96bd> NewList() {
return new RL_7b3475883ca90ad6eb7fc983e868c456();
}


} // RL_7b3475883ca90ad6eb7fc983e868c456
}

