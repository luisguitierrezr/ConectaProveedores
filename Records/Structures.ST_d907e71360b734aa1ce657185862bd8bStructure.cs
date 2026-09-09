namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] OptionalConfigs (DBdHsaHWdUeS5rZxog5UEA)
///  <code>ST_d907e71360b734aa1ce657185862bd8bStructure</code> that represent
/// s <code>OptionalConfigs</code> <p>Description: Set additional parameters to customize the Chart
///  behavior and functionality.</p>
/// </summary>
// Name: OptionalConfigs
public partial struct ST_d907e71360b734aa1ce657185862bd8bStructure : ITypedRecord<ST_d907e71360b734aa1ce657185862bd8bStructure> {
internal static readonly GlobalObjectKey IdDisableLoadingAnimation = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*6xfKnK2Xj0SiD4lZoZFp9g");

public bool ssDisableLoadingAnimation;


public BitArray OptimizedAttributes;

public ST_d907e71360b734aa1ce657185862bd8bStructure() {
OptimizedAttributes = null;
ssDisableLoadingAnimation = false;
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
ssDisableLoadingAnimation = r.ReadBoolean(index++, "OptionalConfigs.DisableLoadingAnimation", false);
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
public void ReadIM(ST_d907e71360b734aa1ce657185862bd8bStructure r) {
this = r;
}


public static bool operator == (ST_d907e71360b734aa1ce657185862bd8bStructure a, ST_d907e71360b734aa1ce657185862bd8bStructure b) {
if (a.ssDisableLoadingAnimation != b.ssDisableLoadingAnimation) return false;
return true;
}

public static bool operator != (ST_d907e71360b734aa1ce657185862bd8bStructure a, ST_d907e71360b734aa1ce657185862bd8bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d907e71360b734aa1ce657185862bd8bStructure)) return false;
return (this == (ST_d907e71360b734aa1ce657185862bd8bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDisableLoadingAnimation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d907e71360b734aa1ce657185862bd8bStructure Duplicate() {
ST_d907e71360b734aa1ce657185862bd8bStructure t;
t.ssDisableLoadingAnimation = this.ssDisableLoadingAnimation;
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
if (head == "disableloadinganimation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DisableLoadingAnimation")) variable.Value = ssDisableLoadingAnimation; else variable.Optimized = true;
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
if (key == IdDisableLoadingAnimation) {
return ssDisableLoadingAnimation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDisableLoadingAnimation.Key.AsGuid) {
return ssDisableLoadingAnimation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDisableLoadingAnimation = (bool) other.AttributeGet(IdDisableLoadingAnimation);
}
} // ST_d907e71360b734aa1ce657185862bd8bStructure
/// <summary>
/// RecordList type <code>OptionalConfigsList</code> that represents a record list of
///  <code>OptionalConfigs</code>
/// </summary>
public partial class RL_da05c2efe4cb7ff61688a1c350e3b05f : GenericRecordList<ST_d907e71360b734aa1ce657185862bd8bStructure>, IEnumerable, IEnumerator {

protected override ST_d907e71360b734aa1ce657185862bd8bStructure GetElementDefaultValue() {
return new ST_d907e71360b734aa1ce657185862bd8bStructure();
}

public T[] ToArray<T>(Func<ST_d907e71360b734aa1ce657185862bd8bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da05c2efe4cb7ff61688a1c350e3b05f recordList, Func<ST_d907e71360b734aa1ce657185862bd8bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da05c2efe4cb7ff61688a1c350e3b05f(ST_d907e71360b734aa1ce657185862bd8bStructure[] array) {
  RL_da05c2efe4cb7ff61688a1c350e3b05f result = new RL_da05c2efe4cb7ff61688a1c350e3b05f();
result.InnerFromArray(array);
    return result;
}

public static RL_da05c2efe4cb7ff61688a1c350e3b05f ToList<T>(T[] array, Func <T, ST_d907e71360b734aa1ce657185862bd8bStructure> converter) {
  RL_da05c2efe4cb7ff61688a1c350e3b05f result = new RL_da05c2efe4cb7ff61688a1c350e3b05f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da05c2efe4cb7ff61688a1c350e3b05f FromRestList<T>(RestList<T> restList, Func <T, ST_d907e71360b734aa1ce657185862bd8bStructure> converter) {
  RL_da05c2efe4cb7ff61688a1c350e3b05f result = new RL_da05c2efe4cb7ff61688a1c350e3b05f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da05c2efe4cb7ff61688a1c350e3b05f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d907e71360b734aa1ce657185862bd8bStructure> NewList() {
return new RL_da05c2efe4cb7ff61688a1c350e3b05f();
}


} // RL_da05c2efe4cb7ff61688a1c350e3b05f
}

