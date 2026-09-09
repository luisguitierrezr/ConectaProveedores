namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qrE1HvZ+10WSAqs3afv01A)
///  <code>RC_986e250fa802967d9a3443950a5e3b6b</code> that represent
/// s <code>InvoiceInvoice_CNRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoice_CNRecord
public partial struct RC_986e250fa802967d9a3443950a5e3b6b : ITypedRecord<RC_986e250fa802967d9a3443950a5e3b6b> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoice_CN = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H_R5HZrmYoYC9Pq5rdjlpw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice_CN;


public BitArray OptimizedAttributes;

public RC_986e250fa802967d9a3443950a5e3b6b() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoice_CN = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(24,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice_CN.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoice_CN.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoice_CN.OptimizedAttributes;
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
ssENInvoice_CN.Read( r, ref index);
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
public void ReadIM(RC_986e250fa802967d9a3443950a5e3b6b r) {
this = r;
}


public static bool operator == (RC_986e250fa802967d9a3443950a5e3b6b a, RC_986e250fa802967d9a3443950a5e3b6b b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoice_CN != b.ssENInvoice_CN) return false;
return true;
}

public static bool operator != (RC_986e250fa802967d9a3443950a5e3b6b a, RC_986e250fa802967d9a3443950a5e3b6b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_986e250fa802967d9a3443950a5e3b6b)) return false;
return (this == (RC_986e250fa802967d9a3443950a5e3b6b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoice_CN.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoice_CN.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoice_CN.InternalRecursiveSave();
}


public RC_986e250fa802967d9a3443950a5e3b6b Duplicate() {
RC_986e250fa802967d9a3443950a5e3b6b t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoice_CN = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice_CN.Duplicate();
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
} else if (head == "invoice_cn") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice_CN")) variable.Value = ssENInvoice_CN; else variable.Optimized = true;
variable.SetFieldName("invoice_cn");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoice_CN) {
return ssENInvoice_CN;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoice_CN.Key.AsGuid) {
return ssENInvoice_CN;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoice_CN.FillFromOther((IRecord) other.AttributeGet(IdInvoice_CN));
}
} // RC_986e250fa802967d9a3443950a5e3b6b
/// <summary>
/// RecordList type <code>InvoiceInvoice_CNRecordList</code> that represents a record list of
///  <code>Invoice, Invoice</code>
/// </summary>
public partial class RL_29ee9e201d1174176a9cb64aac6297ba : GenericRecordList<RC_986e250fa802967d9a3443950a5e3b6b>, IEnumerable, IEnumerator {

protected override RC_986e250fa802967d9a3443950a5e3b6b GetElementDefaultValue() {
return new RC_986e250fa802967d9a3443950a5e3b6b();
}

public T[] ToArray<T>(Func<RC_986e250fa802967d9a3443950a5e3b6b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_29ee9e201d1174176a9cb64aac6297ba recordList, Func<RC_986e250fa802967d9a3443950a5e3b6b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_29ee9e201d1174176a9cb64aac6297ba(RC_986e250fa802967d9a3443950a5e3b6b[] array) {
  RL_29ee9e201d1174176a9cb64aac6297ba result = new RL_29ee9e201d1174176a9cb64aac6297ba();
result.InnerFromArray(array);
    return result;
}

public static RL_29ee9e201d1174176a9cb64aac6297ba ToList<T>(T[] array, Func <T, RC_986e250fa802967d9a3443950a5e3b6b> converter) {
  RL_29ee9e201d1174176a9cb64aac6297ba result = new RL_29ee9e201d1174176a9cb64aac6297ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_29ee9e201d1174176a9cb64aac6297ba FromRestList<T>(RestList<T> restList, Func <T, RC_986e250fa802967d9a3443950a5e3b6b> converter) {
  RL_29ee9e201d1174176a9cb64aac6297ba result = new RL_29ee9e201d1174176a9cb64aac6297ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_29ee9e201d1174176a9cb64aac6297ba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(24,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_986e250fa802967d9a3443950a5e3b6b> NewList() {
return new RL_29ee9e201d1174176a9cb64aac6297ba();
}


} // RL_29ee9e201d1174176a9cb64aac6297ba
}

