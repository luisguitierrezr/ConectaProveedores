namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (s5Z0Y498lUa0H4h4A3Cfsg)
///  <code>RC_7cb091de697d14a1ce465208aa77fcb0</code> that represent
/// s <code>InvoiceFileStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFileStorageRecord
public partial struct RC_7cb091de697d14a1ce465208aa77fcb0 : ITypedRecord<RC_7cb091de697d14a1ce465208aa77fcb0> {
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_7cb091de697d14a1ce465208aa77fcb0() {
OptimizedAttributes = null;
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceFile.OptimizedAttributes = value[0];
    ssENStorage.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceFile.OptimizedAttributes;
    all[1] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceFile.Read( r, ref index);
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_7cb091de697d14a1ce465208aa77fcb0 r) {
this = r;
}


public static bool operator == (RC_7cb091de697d14a1ce465208aa77fcb0 a, RC_7cb091de697d14a1ce465208aa77fcb0 b) {
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_7cb091de697d14a1ce465208aa77fcb0 a, RC_7cb091de697d14a1ce465208aa77fcb0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7cb091de697d14a1ce465208aa77fcb0)) return false;
return (this == (RC_7cb091de697d14a1ce465208aa77fcb0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceFile.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceFile.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_7cb091de697d14a1ce465208aa77fcb0 Duplicate() {
RC_7cb091de697d14a1ce465208aa77fcb0 t;
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
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
if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
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
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_7cb091de697d14a1ce465208aa77fcb0
/// <summary>
/// RecordList type <code>InvoiceFileStorageRecordList</code> that represents a record list of
///  <code>InvoiceFile, Storage</code>
/// </summary>
public partial class RL_e40371698c3bd2f83f525cf47c117634 : GenericRecordList<RC_7cb091de697d14a1ce465208aa77fcb0>, IEnumerable, IEnumerator {

protected override RC_7cb091de697d14a1ce465208aa77fcb0 GetElementDefaultValue() {
return new RC_7cb091de697d14a1ce465208aa77fcb0();
}

public T[] ToArray<T>(Func<RC_7cb091de697d14a1ce465208aa77fcb0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e40371698c3bd2f83f525cf47c117634 recordList, Func<RC_7cb091de697d14a1ce465208aa77fcb0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e40371698c3bd2f83f525cf47c117634(RC_7cb091de697d14a1ce465208aa77fcb0[] array) {
  RL_e40371698c3bd2f83f525cf47c117634 result = new RL_e40371698c3bd2f83f525cf47c117634();
result.InnerFromArray(array);
    return result;
}

public static RL_e40371698c3bd2f83f525cf47c117634 ToList<T>(T[] array, Func <T, RC_7cb091de697d14a1ce465208aa77fcb0> converter) {
  RL_e40371698c3bd2f83f525cf47c117634 result = new RL_e40371698c3bd2f83f525cf47c117634();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e40371698c3bd2f83f525cf47c117634 FromRestList<T>(RestList<T> restList, Func <T, RC_7cb091de697d14a1ce465208aa77fcb0> converter) {
  RL_e40371698c3bd2f83f525cf47c117634 result = new RL_e40371698c3bd2f83f525cf47c117634();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e40371698c3bd2f83f525cf47c117634() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7cb091de697d14a1ce465208aa77fcb0> NewList() {
return new RL_e40371698c3bd2f83f525cf47c117634();
}


} // RL_e40371698c3bd2f83f525cf47c117634
}

