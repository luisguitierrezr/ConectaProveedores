namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] NotificationOptionalConfigs (IxY49z4xnEGSvDzPv6m2oA)
///  <code>ST_09173c1b0f41f719b9efd6430c2e737dStructure</code> that represent
/// s <code>NotificationOptionalConfigs</code> <p>Description: Group of optional configurations for the
///  Notification block. </p>
/// </summary>
// Name: NotificationOptionalConfigs
public partial struct ST_09173c1b0f41f719b9efd6430c2e737dStructure : ITypedRecord<ST_09173c1b0f41f719b9efd6430c2e737dStructure> {
internal static readonly GlobalObjectKey IdInteractToClose = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xWuHFWft3U6IsRoTIqH2Rw");
internal static readonly GlobalObjectKey IdCloseAfterTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*I15QtFhXGk+admD4bZC2zg");

public bool ssInteractToClose;

public int ssCloseAfterTime;


public BitArray OptimizedAttributes;

public ST_09173c1b0f41f719b9efd6430c2e737dStructure() {
OptimizedAttributes = null;
ssInteractToClose = true;
ssCloseAfterTime = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssInteractToClose = r.ReadBoolean(index++, "NotificationOptionalConfigs.InteractToClose", false);
ssCloseAfterTime = r.ReadInteger(index++, "NotificationOptionalConfigs.CloseAfterTime", 0);
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
public void ReadIM(ST_09173c1b0f41f719b9efd6430c2e737dStructure r) {
this = r;
}


public static bool operator == (ST_09173c1b0f41f719b9efd6430c2e737dStructure a, ST_09173c1b0f41f719b9efd6430c2e737dStructure b) {
if (a.ssInteractToClose != b.ssInteractToClose) return false;
if (a.ssCloseAfterTime != b.ssCloseAfterTime) return false;
return true;
}

public static bool operator != (ST_09173c1b0f41f719b9efd6430c2e737dStructure a, ST_09173c1b0f41f719b9efd6430c2e737dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_09173c1b0f41f719b9efd6430c2e737dStructure)) return false;
return (this == (ST_09173c1b0f41f719b9efd6430c2e737dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInteractToClose.GetHashCode()
 ^ ssCloseAfterTime.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_09173c1b0f41f719b9efd6430c2e737dStructure Duplicate() {
ST_09173c1b0f41f719b9efd6430c2e737dStructure t;
t.ssInteractToClose = this.ssInteractToClose;
t.ssCloseAfterTime = this.ssCloseAfterTime;
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
if (head == "interacttoclose") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InteractToClose")) variable.Value = ssInteractToClose; else variable.Optimized = true;
} else if (head == "closeaftertime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CloseAfterTime")) variable.Value = ssCloseAfterTime; else variable.Optimized = true;
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
if (key == IdInteractToClose) {
return ssInteractToClose;
}
if (key == IdCloseAfterTime) {
return ssCloseAfterTime;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInteractToClose.Key.AsGuid) {
return ssInteractToClose;
}
if (attributeKey == IdCloseAfterTime.Key.AsGuid) {
return ssCloseAfterTime;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInteractToClose = (bool) other.AttributeGet(IdInteractToClose);
ssCloseAfterTime = (int) other.AttributeGet(IdCloseAfterTime);
}
} // ST_09173c1b0f41f719b9efd6430c2e737dStructure
/// <summary>
/// RecordList type <code>NotificationOptionalConfigsList</code> that represents a record list of
///  <code>NotificationOptionalConfigs</code>
/// </summary>
public partial class RL_d689c0ceaaa6201af233ffc179beef2f : GenericRecordList<ST_09173c1b0f41f719b9efd6430c2e737dStructure>, IEnumerable, IEnumerator {

protected override ST_09173c1b0f41f719b9efd6430c2e737dStructure GetElementDefaultValue() {
return new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
}

public T[] ToArray<T>(Func<ST_09173c1b0f41f719b9efd6430c2e737dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d689c0ceaaa6201af233ffc179beef2f recordList, Func<ST_09173c1b0f41f719b9efd6430c2e737dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d689c0ceaaa6201af233ffc179beef2f(ST_09173c1b0f41f719b9efd6430c2e737dStructure[] array) {
  RL_d689c0ceaaa6201af233ffc179beef2f result = new RL_d689c0ceaaa6201af233ffc179beef2f();
result.InnerFromArray(array);
    return result;
}

public static RL_d689c0ceaaa6201af233ffc179beef2f ToList<T>(T[] array, Func <T, ST_09173c1b0f41f719b9efd6430c2e737dStructure> converter) {
  RL_d689c0ceaaa6201af233ffc179beef2f result = new RL_d689c0ceaaa6201af233ffc179beef2f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d689c0ceaaa6201af233ffc179beef2f FromRestList<T>(RestList<T> restList, Func <T, ST_09173c1b0f41f719b9efd6430c2e737dStructure> converter) {
  RL_d689c0ceaaa6201af233ffc179beef2f result = new RL_d689c0ceaaa6201af233ffc179beef2f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d689c0ceaaa6201af233ffc179beef2f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_09173c1b0f41f719b9efd6430c2e737dStructure> NewList() {
return new RL_d689c0ceaaa6201af233ffc179beef2f();
}


} // RL_d689c0ceaaa6201af233ffc179beef2f
}

