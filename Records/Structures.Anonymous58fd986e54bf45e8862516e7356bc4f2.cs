namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bpj9WL9U6EWGJRbnNWvE8g)
///  <code>RC_9108d3e2654ece9110f56afaa300db01</code> that represent
/// s <code>FolioFilesStructRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioFilesStructRecord
public partial struct RC_9108d3e2654ece9110f56afaa300db01 : ITypedRecord<RC_9108d3e2654ece9110f56afaa300db01> {
internal static readonly GlobalObjectKey IdFolioFilesStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4tMIkU5lkc4Q9Wr6owDbAQ");

public ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure ssSTFolioFilesStruct;


public static implicit operator ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure( RC_9108d3e2654ece9110f56afaa300db01 r) {
return r.ssSTFolioFilesStruct;
}

public static implicit operator RC_9108d3e2654ece9110f56afaa300db01 (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure r) {
RC_9108d3e2654ece9110f56afaa300db01 res = new RC_9108d3e2654ece9110f56afaa300db01 ();
res.ssSTFolioFilesStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9108d3e2654ece9110f56afaa300db01() {
OptimizedAttributes = null;
ssSTFolioFilesStruct = new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTFolioFilesStruct.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTFolioFilesStruct.Read( r, ref index);
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
public void ReadIM(RC_9108d3e2654ece9110f56afaa300db01 r) {
this = r;
}


public static bool operator == (RC_9108d3e2654ece9110f56afaa300db01 a, RC_9108d3e2654ece9110f56afaa300db01 b) {
if (a.ssSTFolioFilesStruct != b.ssSTFolioFilesStruct) return false;
return true;
}

public static bool operator != (RC_9108d3e2654ece9110f56afaa300db01 a, RC_9108d3e2654ece9110f56afaa300db01 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9108d3e2654ece9110f56afaa300db01)) return false;
return (this == (RC_9108d3e2654ece9110f56afaa300db01)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioFilesStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioFilesStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioFilesStruct.InternalRecursiveSave();
}


public RC_9108d3e2654ece9110f56afaa300db01 Duplicate() {
RC_9108d3e2654ece9110f56afaa300db01 t;
t.ssSTFolioFilesStruct = (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure)this.ssSTFolioFilesStruct.Duplicate();
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
if (head == "foliofilesstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFilesStruct")) variable.Value = ssSTFolioFilesStruct; else variable.Optimized = true;
variable.SetFieldName("foliofilesstruct");
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
if (key == IdFolioFilesStruct) {
return ssSTFolioFilesStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioFilesStruct.Key.AsGuid) {
return ssSTFolioFilesStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioFilesStruct.FillFromOther((IRecord) other.AttributeGet(IdFolioFilesStruct));
}
} // RC_9108d3e2654ece9110f56afaa300db01
/// <summary>
/// RecordList type <code>FolioFilesStructRecordList</code> that represents a record list of
///  <code>FolioFilesStruct</code>
/// </summary>
public partial class RL_0f1b4cd6eb390f22db90e5d31d09859f : GenericRecordList<RC_9108d3e2654ece9110f56afaa300db01>, IEnumerable, IEnumerator {

protected override RC_9108d3e2654ece9110f56afaa300db01 GetElementDefaultValue() {
return new RC_9108d3e2654ece9110f56afaa300db01();
}

public T[] ToArray<T>(Func<RC_9108d3e2654ece9110f56afaa300db01, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0f1b4cd6eb390f22db90e5d31d09859f recordList, Func<RC_9108d3e2654ece9110f56afaa300db01, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0f1b4cd6eb390f22db90e5d31d09859f(RC_9108d3e2654ece9110f56afaa300db01[] array) {
  RL_0f1b4cd6eb390f22db90e5d31d09859f result = new RL_0f1b4cd6eb390f22db90e5d31d09859f();
result.InnerFromArray(array);
    return result;
}

public static RL_0f1b4cd6eb390f22db90e5d31d09859f ToList<T>(T[] array, Func <T, RC_9108d3e2654ece9110f56afaa300db01> converter) {
  RL_0f1b4cd6eb390f22db90e5d31d09859f result = new RL_0f1b4cd6eb390f22db90e5d31d09859f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0f1b4cd6eb390f22db90e5d31d09859f FromRestList<T>(RestList<T> restList, Func <T, RC_9108d3e2654ece9110f56afaa300db01> converter) {
  RL_0f1b4cd6eb390f22db90e5d31d09859f result = new RL_0f1b4cd6eb390f22db90e5d31d09859f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0f1b4cd6eb390f22db90e5d31d09859f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9108d3e2654ece9110f56afaa300db01> NewList() {
return new RL_0f1b4cd6eb390f22db90e5d31d09859f();
}


} // RL_0f1b4cd6eb390f22db90e5d31d09859f
}

