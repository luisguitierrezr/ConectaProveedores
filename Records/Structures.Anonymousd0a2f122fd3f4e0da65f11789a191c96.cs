namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IvGi0D_9DU6mXxF4mhkclg)
///  <code>RC_6748c146370600806f2500c8b8a2cb25</code> that represents <code>PaperSizeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaperSizeRecord
public partial struct RC_6748c146370600806f2500c8b8a2cb25 : ITypedRecord<RC_6748c146370600806f2500c8b8a2cb25> {
internal static readonly GlobalObjectKey IdPaperSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RsFIZwY3gABvJQDIuKLLJQ");

public EN_7f47ecde673669f1866fae1765d30761EntityRecord ssENPaperSize;


public static implicit operator EN_7f47ecde673669f1866fae1765d30761EntityRecord( RC_6748c146370600806f2500c8b8a2cb25 r) {
return r.ssENPaperSize;
}

public static implicit operator RC_6748c146370600806f2500c8b8a2cb25 (EN_7f47ecde673669f1866fae1765d30761EntityRecord r) {
RC_6748c146370600806f2500c8b8a2cb25 res = new RC_6748c146370600806f2500c8b8a2cb25 ();
res.ssENPaperSize = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPaperSize.ChangedAttributes = value;
}
get {
    return ssENPaperSize.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6748c146370600806f2500c8b8a2cb25() {
OptimizedAttributes = null;
ssENPaperSize = new EN_7f47ecde673669f1866fae1765d30761EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPaperSize.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPaperSize.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPaperSize.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPaperSize.Read( r, ref index);
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
public void ReadIM(RC_6748c146370600806f2500c8b8a2cb25 r) {
this = r;
}


public static bool operator == (RC_6748c146370600806f2500c8b8a2cb25 a, RC_6748c146370600806f2500c8b8a2cb25 b) {
if (a.ssENPaperSize != b.ssENPaperSize) return false;
return true;
}

public static bool operator != (RC_6748c146370600806f2500c8b8a2cb25 a, RC_6748c146370600806f2500c8b8a2cb25 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6748c146370600806f2500c8b8a2cb25)) return false;
return (this == (RC_6748c146370600806f2500c8b8a2cb25)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPaperSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPaperSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPaperSize.InternalRecursiveSave();
}


public RC_6748c146370600806f2500c8b8a2cb25 Duplicate() {
RC_6748c146370600806f2500c8b8a2cb25 t;
t.ssENPaperSize = (EN_7f47ecde673669f1866fae1765d30761EntityRecord)this.ssENPaperSize.Duplicate();
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
if (head == "papersize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaperSize")) variable.Value = ssENPaperSize; else variable.Optimized = true;
variable.SetFieldName("papersize");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPaperSize.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPaperSize.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPaperSize) {
return ssENPaperSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaperSize.Key.AsGuid) {
return ssENPaperSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPaperSize.FillFromOther((IRecord) other.AttributeGet(IdPaperSize));
}
} // RC_6748c146370600806f2500c8b8a2cb25
/// <summary>
/// RecordList type <code>PaperSizeRecordList</code> that represents a record list of
///  <code>PaperSize</code>
/// </summary>
public partial class RL_5893e9b1f6b161988eb57c646f00cf91 : GenericRecordList<RC_6748c146370600806f2500c8b8a2cb25>, IEnumerable, IEnumerator {

protected override RC_6748c146370600806f2500c8b8a2cb25 GetElementDefaultValue() {
return new RC_6748c146370600806f2500c8b8a2cb25();
}

public T[] ToArray<T>(Func<RC_6748c146370600806f2500c8b8a2cb25, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5893e9b1f6b161988eb57c646f00cf91 recordList, Func<RC_6748c146370600806f2500c8b8a2cb25, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5893e9b1f6b161988eb57c646f00cf91(RC_6748c146370600806f2500c8b8a2cb25[] array) {
  RL_5893e9b1f6b161988eb57c646f00cf91 result = new RL_5893e9b1f6b161988eb57c646f00cf91();
result.InnerFromArray(array);
    return result;
}

public static RL_5893e9b1f6b161988eb57c646f00cf91 ToList<T>(T[] array, Func <T, RC_6748c146370600806f2500c8b8a2cb25> converter) {
  RL_5893e9b1f6b161988eb57c646f00cf91 result = new RL_5893e9b1f6b161988eb57c646f00cf91();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5893e9b1f6b161988eb57c646f00cf91 FromRestList<T>(RestList<T> restList, Func <T, RC_6748c146370600806f2500c8b8a2cb25> converter) {
  RL_5893e9b1f6b161988eb57c646f00cf91 result = new RL_5893e9b1f6b161988eb57c646f00cf91();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5893e9b1f6b161988eb57c646f00cf91() : base() {
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
protected override OSList<RC_6748c146370600806f2500c8b8a2cb25> NewList() {
return new RL_5893e9b1f6b161988eb57c646f00cf91();
}


} // RL_5893e9b1f6b161988eb57c646f00cf91
}

