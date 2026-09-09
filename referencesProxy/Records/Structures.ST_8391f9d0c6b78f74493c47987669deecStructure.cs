namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ProgressBarOptionalConfigs (7coAXrNWLEOM9+N4YlDmMg)
///  <code>ST_8391f9d0c6b78f74493c47987669deecStructure</code> that represent
/// s <code>ProgressBarOptionalConfigs</code> <p>Description: Group of optional configurations for the
///  ProgressBar block. </p>
/// </summary>
// Name: ProgressBarOptionalConfigs
public partial struct ST_8391f9d0c6b78f74493c47987669deecStructure : ITypedRecord<ST_8391f9d0c6b78f74493c47987669deecStructure> {
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*x1DdMxCZvk+g4G++8CqAVw");
internal static readonly GlobalObjectKey IdAnimateInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*npswON4uCU+_ky2V5GIH9w");

public string ssShape;

public bool ssAnimateInitialProgress;


public BitArray OptimizedAttributes;

public ST_8391f9d0c6b78f74493c47987669deecStructure() {
OptimizedAttributes = null;
ssShape = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_ProgressBarOptionalConfigs_ReferenceStructureAttribute_Shape;
ssAnimateInitialProgress = true;
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
ssShape = r.ReadEntityReferenceText(index++, "ProgressBarOptionalConfigs.Shape", "");
ssAnimateInitialProgress = r.ReadBoolean(index++, "ProgressBarOptionalConfigs.AnimateInitialProgress", false);
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
public void ReadIM(ST_8391f9d0c6b78f74493c47987669deecStructure r) {
this = r;
}


public static bool operator == (ST_8391f9d0c6b78f74493c47987669deecStructure a, ST_8391f9d0c6b78f74493c47987669deecStructure b) {
if (a.ssShape != b.ssShape) return false;
if (a.ssAnimateInitialProgress != b.ssAnimateInitialProgress) return false;
return true;
}

public static bool operator != (ST_8391f9d0c6b78f74493c47987669deecStructure a, ST_8391f9d0c6b78f74493c47987669deecStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8391f9d0c6b78f74493c47987669deecStructure)) return false;
return (this == (ST_8391f9d0c6b78f74493c47987669deecStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShape.GetHashCode()
 ^ ssAnimateInitialProgress.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8391f9d0c6b78f74493c47987669deecStructure Duplicate() {
ST_8391f9d0c6b78f74493c47987669deecStructure t;
t.ssShape = this.ssShape;
t.ssAnimateInitialProgress = this.ssAnimateInitialProgress;
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
if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssShape; else variable.Optimized = true;
} else if (head == "animateinitialprogress") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimateInitialProgress")) variable.Value = ssAnimateInitialProgress; else variable.Optimized = true;
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
if (key == IdShape) {
return ssShape;
}
if (key == IdAnimateInitialProgress) {
return ssAnimateInitialProgress;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShape.Key.AsGuid) {
return ssShape;
}
if (attributeKey == IdAnimateInitialProgress.Key.AsGuid) {
return ssAnimateInitialProgress;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssShape = (string) other.AttributeGet(IdShape);
ssAnimateInitialProgress = (bool) other.AttributeGet(IdAnimateInitialProgress);
}
} // ST_8391f9d0c6b78f74493c47987669deecStructure
/// <summary>
/// RecordList type <code>ProgressBarOptionalConfigsList</code> that represents a record list of
///  <code>ProgressBarOptionalConfigs</code>
/// </summary>
public partial class RL_3cfea1a1e933b75750f570ea368d3da2 : GenericRecordList<ST_8391f9d0c6b78f74493c47987669deecStructure>, IEnumerable, IEnumerator {

protected override ST_8391f9d0c6b78f74493c47987669deecStructure GetElementDefaultValue() {
return new ST_8391f9d0c6b78f74493c47987669deecStructure();
}

public T[] ToArray<T>(Func<ST_8391f9d0c6b78f74493c47987669deecStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3cfea1a1e933b75750f570ea368d3da2 recordList, Func<ST_8391f9d0c6b78f74493c47987669deecStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3cfea1a1e933b75750f570ea368d3da2(ST_8391f9d0c6b78f74493c47987669deecStructure[] array) {
  RL_3cfea1a1e933b75750f570ea368d3da2 result = new RL_3cfea1a1e933b75750f570ea368d3da2();
result.InnerFromArray(array);
    return result;
}

public static RL_3cfea1a1e933b75750f570ea368d3da2 ToList<T>(T[] array, Func <T, ST_8391f9d0c6b78f74493c47987669deecStructure> converter) {
  RL_3cfea1a1e933b75750f570ea368d3da2 result = new RL_3cfea1a1e933b75750f570ea368d3da2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3cfea1a1e933b75750f570ea368d3da2 FromRestList<T>(RestList<T> restList, Func <T, ST_8391f9d0c6b78f74493c47987669deecStructure> converter) {
  RL_3cfea1a1e933b75750f570ea368d3da2 result = new RL_3cfea1a1e933b75750f570ea368d3da2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3cfea1a1e933b75750f570ea368d3da2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8391f9d0c6b78f74493c47987669deecStructure> NewList() {
return new RL_3cfea1a1e933b75750f570ea368d3da2();
}


} // RL_3cfea1a1e933b75750f570ea368d3da2
}

