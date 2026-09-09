namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pxVu8JSDBEOQleekjZk3tA)
///  <code>RC_1d614602032ba1d6426327cab15c1a37</code> that represents <code>FileImportLogRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FileImportLogRecord
public partial struct RC_1d614602032ba1d6426327cab15c1a37 : ITypedRecord<RC_1d614602032ba1d6426327cab15c1a37> {
internal static readonly GlobalObjectKey IdFileImportLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AkZhHSsD1qFCYyfKsVwaNw");

public EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog;


public static implicit operator EN_57456f779b1d12573357da68381e59ceEntityRecord( RC_1d614602032ba1d6426327cab15c1a37 r) {
return r.ssENFileImportLog;
}

public static implicit operator RC_1d614602032ba1d6426327cab15c1a37 (EN_57456f779b1d12573357da68381e59ceEntityRecord r) {
RC_1d614602032ba1d6426327cab15c1a37 res = new RC_1d614602032ba1d6426327cab15c1a37 ();
res.ssENFileImportLog = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFileImportLog.ChangedAttributes = value;
}
get {
    return ssENFileImportLog.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1d614602032ba1d6426327cab15c1a37() {
OptimizedAttributes = null;
ssENFileImportLog = new EN_57456f779b1d12573357da68381e59ceEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFileImportLog.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFileImportLog.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFileImportLog.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFileImportLog.Read( r, ref index);
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
public void ReadIM(RC_1d614602032ba1d6426327cab15c1a37 r) {
this = r;
}


public static bool operator == (RC_1d614602032ba1d6426327cab15c1a37 a, RC_1d614602032ba1d6426327cab15c1a37 b) {
if (a.ssENFileImportLog != b.ssENFileImportLog) return false;
return true;
}

public static bool operator != (RC_1d614602032ba1d6426327cab15c1a37 a, RC_1d614602032ba1d6426327cab15c1a37 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1d614602032ba1d6426327cab15c1a37)) return false;
return (this == (RC_1d614602032ba1d6426327cab15c1a37)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFileImportLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFileImportLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFileImportLog.InternalRecursiveSave();
}


public RC_1d614602032ba1d6426327cab15c1a37 Duplicate() {
RC_1d614602032ba1d6426327cab15c1a37 t;
t.ssENFileImportLog = (EN_57456f779b1d12573357da68381e59ceEntityRecord)this.ssENFileImportLog.Duplicate();
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
if (head == "fileimportlog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileImportLog")) variable.Value = ssENFileImportLog; else variable.Optimized = true;
variable.SetFieldName("fileimportlog");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFileImportLog.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFileImportLog.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFileImportLog) {
return ssENFileImportLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileImportLog.Key.AsGuid) {
return ssENFileImportLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFileImportLog.FillFromOther((IRecord) other.AttributeGet(IdFileImportLog));
}
} // RC_1d614602032ba1d6426327cab15c1a37
/// <summary>
/// RecordList type <code>FileImportLogRecordList</code> that represents a record list of
///  <code>FileImportLog</code>
/// </summary>
public partial class RL_0101cfa484875f3eb391d3382eef891a : GenericRecordList<RC_1d614602032ba1d6426327cab15c1a37>, IEnumerable, IEnumerator {

protected override RC_1d614602032ba1d6426327cab15c1a37 GetElementDefaultValue() {
return new RC_1d614602032ba1d6426327cab15c1a37();
}

public T[] ToArray<T>(Func<RC_1d614602032ba1d6426327cab15c1a37, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0101cfa484875f3eb391d3382eef891a recordList, Func<RC_1d614602032ba1d6426327cab15c1a37, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0101cfa484875f3eb391d3382eef891a(RC_1d614602032ba1d6426327cab15c1a37[] array) {
  RL_0101cfa484875f3eb391d3382eef891a result = new RL_0101cfa484875f3eb391d3382eef891a();
result.InnerFromArray(array);
    return result;
}

public static RL_0101cfa484875f3eb391d3382eef891a ToList<T>(T[] array, Func <T, RC_1d614602032ba1d6426327cab15c1a37> converter) {
  RL_0101cfa484875f3eb391d3382eef891a result = new RL_0101cfa484875f3eb391d3382eef891a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0101cfa484875f3eb391d3382eef891a FromRestList<T>(RestList<T> restList, Func <T, RC_1d614602032ba1d6426327cab15c1a37> converter) {
  RL_0101cfa484875f3eb391d3382eef891a result = new RL_0101cfa484875f3eb391d3382eef891a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0101cfa484875f3eb391d3382eef891a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1d614602032ba1d6426327cab15c1a37> NewList() {
return new RL_0101cfa484875f3eb391d3382eef891a();
}


} // RL_0101cfa484875f3eb391d3382eef891a
}

