namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (x8HYsByg3kOLKOyIA0Kyzw)
///  <code>RC_03619642a06de09478f0b8f506c364eb</code> that represents <code>VideoStateRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: VideoStateRecord
public partial struct RC_03619642a06de09478f0b8f506c364eb : ITypedRecord<RC_03619642a06de09478f0b8f506c364eb> {
internal static readonly GlobalObjectKey IdVideoState = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QpZhA22glOB48Lj1BsNk6w");

public EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord ssENVideoState;


public static implicit operator EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord( RC_03619642a06de09478f0b8f506c364eb r) {
return r.ssENVideoState;
}

public static implicit operator RC_03619642a06de09478f0b8f506c364eb (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord r) {
RC_03619642a06de09478f0b8f506c364eb res = new RC_03619642a06de09478f0b8f506c364eb ();
res.ssENVideoState = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENVideoState.ChangedAttributes = value;
}
get {
    return ssENVideoState.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_03619642a06de09478f0b8f506c364eb() {
OptimizedAttributes = null;
ssENVideoState = new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENVideoState.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENVideoState.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENVideoState.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENVideoState.Read( r, ref index);
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
public void ReadIM(RC_03619642a06de09478f0b8f506c364eb r) {
this = r;
}


public static bool operator == (RC_03619642a06de09478f0b8f506c364eb a, RC_03619642a06de09478f0b8f506c364eb b) {
if (a.ssENVideoState != b.ssENVideoState) return false;
return true;
}

public static bool operator != (RC_03619642a06de09478f0b8f506c364eb a, RC_03619642a06de09478f0b8f506c364eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_03619642a06de09478f0b8f506c364eb)) return false;
return (this == (RC_03619642a06de09478f0b8f506c364eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENVideoState.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENVideoState.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENVideoState.InternalRecursiveSave();
}


public RC_03619642a06de09478f0b8f506c364eb Duplicate() {
RC_03619642a06de09478f0b8f506c364eb t;
t.ssENVideoState = (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord)this.ssENVideoState.Duplicate();
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
if (head == "videostate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VideoState")) variable.Value = ssENVideoState; else variable.Optimized = true;
variable.SetFieldName("videostate");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENVideoState.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENVideoState.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdVideoState) {
return ssENVideoState;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVideoState.Key.AsGuid) {
return ssENVideoState;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENVideoState.FillFromOther((IRecord) other.AttributeGet(IdVideoState));
}
} // RC_03619642a06de09478f0b8f506c364eb
/// <summary>
/// RecordList type <code>VideoStateRecordList</code> that represents a record list of
///  <code>VideoState</code>
/// </summary>
public partial class RL_62db41b41dbf507c50e0bafe4d455ef4 : GenericRecordList<RC_03619642a06de09478f0b8f506c364eb>, IEnumerable, IEnumerator {

protected override RC_03619642a06de09478f0b8f506c364eb GetElementDefaultValue() {
return new RC_03619642a06de09478f0b8f506c364eb();
}

public T[] ToArray<T>(Func<RC_03619642a06de09478f0b8f506c364eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_62db41b41dbf507c50e0bafe4d455ef4 recordList, Func<RC_03619642a06de09478f0b8f506c364eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_62db41b41dbf507c50e0bafe4d455ef4(RC_03619642a06de09478f0b8f506c364eb[] array) {
  RL_62db41b41dbf507c50e0bafe4d455ef4 result = new RL_62db41b41dbf507c50e0bafe4d455ef4();
result.InnerFromArray(array);
    return result;
}

public static RL_62db41b41dbf507c50e0bafe4d455ef4 ToList<T>(T[] array, Func <T, RC_03619642a06de09478f0b8f506c364eb> converter) {
  RL_62db41b41dbf507c50e0bafe4d455ef4 result = new RL_62db41b41dbf507c50e0bafe4d455ef4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_62db41b41dbf507c50e0bafe4d455ef4 FromRestList<T>(RestList<T> restList, Func <T, RC_03619642a06de09478f0b8f506c364eb> converter) {
  RL_62db41b41dbf507c50e0bafe4d455ef4 result = new RL_62db41b41dbf507c50e0bafe4d455ef4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_62db41b41dbf507c50e0bafe4d455ef4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_03619642a06de09478f0b8f506c364eb> NewList() {
return new RL_62db41b41dbf507c50e0bafe4d455ef4();
}


} // RL_62db41b41dbf507c50e0bafe4d455ef4
}

