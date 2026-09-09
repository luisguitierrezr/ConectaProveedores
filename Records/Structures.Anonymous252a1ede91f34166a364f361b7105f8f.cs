namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3h4qJfORZkGjZPNhtxBfjw)
///  <code>RC_2b77a78552d1dad3876c3ebd8f5c8ec1</code> that represent
/// s <code>InvoiceInvoiceFileRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceFileRecord
public partial struct RC_2b77a78552d1dad3876c3ebd8f5c8ec1 : ITypedRecord<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;


public BitArray OptimizedAttributes;

public RC_2b77a78552d1dad3876c3ebd8f5c8ec1() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceFile.OptimizedAttributes;
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
ssENInvoiceFile.Read( r, ref index);
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
public void ReadIM(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 r) {
this = r;
}


public static bool operator == (RC_2b77a78552d1dad3876c3ebd8f5c8ec1 a, RC_2b77a78552d1dad3876c3ebd8f5c8ec1 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
return true;
}

public static bool operator != (RC_2b77a78552d1dad3876c3ebd8f5c8ec1 a, RC_2b77a78552d1dad3876c3ebd8f5c8ec1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2b77a78552d1dad3876c3ebd8f5c8ec1)) return false;
return (this == (RC_2b77a78552d1dad3876c3ebd8f5c8ec1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
}


public RC_2b77a78552d1dad3876c3ebd8f5c8ec1 Duplicate() {
RC_2b77a78552d1dad3876c3ebd8f5c8ec1 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
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
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
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
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
}
} // RC_2b77a78552d1dad3876c3ebd8f5c8ec1
/// <summary>
/// RecordList type <code>InvoiceInvoiceFileRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceFile</code>
/// </summary>
public partial class RL_ff28012de5324af3e81e5ace09ecb1f0 : GenericRecordList<RC_2b77a78552d1dad3876c3ebd8f5c8ec1>, IEnumerable, IEnumerator {

protected override RC_2b77a78552d1dad3876c3ebd8f5c8ec1 GetElementDefaultValue() {
return new RC_2b77a78552d1dad3876c3ebd8f5c8ec1();
}

public T[] ToArray<T>(Func<RC_2b77a78552d1dad3876c3ebd8f5c8ec1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff28012de5324af3e81e5ace09ecb1f0 recordList, Func<RC_2b77a78552d1dad3876c3ebd8f5c8ec1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff28012de5324af3e81e5ace09ecb1f0(RC_2b77a78552d1dad3876c3ebd8f5c8ec1[] array) {
  RL_ff28012de5324af3e81e5ace09ecb1f0 result = new RL_ff28012de5324af3e81e5ace09ecb1f0();
result.InnerFromArray(array);
    return result;
}

public static RL_ff28012de5324af3e81e5ace09ecb1f0 ToList<T>(T[] array, Func <T, RC_2b77a78552d1dad3876c3ebd8f5c8ec1> converter) {
  RL_ff28012de5324af3e81e5ace09ecb1f0 result = new RL_ff28012de5324af3e81e5ace09ecb1f0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff28012de5324af3e81e5ace09ecb1f0 FromRestList<T>(RestList<T> restList, Func <T, RC_2b77a78552d1dad3876c3ebd8f5c8ec1> converter) {
  RL_ff28012de5324af3e81e5ace09ecb1f0 result = new RL_ff28012de5324af3e81e5ace09ecb1f0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff28012de5324af3e81e5ace09ecb1f0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> NewList() {
return new RL_ff28012de5324af3e81e5ace09ecb1f0();
}


} // RL_ff28012de5324af3e81e5ace09ecb1f0
}

