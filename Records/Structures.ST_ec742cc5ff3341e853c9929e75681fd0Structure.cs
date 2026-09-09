namespace ssConectaProveedores {
/// <summary>
/// [Structure] UniquesCeBeCeCo (y86rz+NvZUWubWxjIGzq_w)
///  <code>ST_ec742cc5ff3341e853c9929e75681fd0Structure</code> that represent
/// s <code>UniquesCeBeCeCo</code> <p>Description: </p>
/// </summary>
// Name: UniquesCeBeCeCo
public partial struct ST_ec742cc5ff3341e853c9929e75681fd0Structure : ITypedRecord<ST_ec742cc5ff3341e853c9929e75681fd0Structure> {
internal static readonly GlobalObjectKey IdCeCo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*84Azp2wTjE2tt0t8JMKjQQ");
internal static readonly GlobalObjectKey IdCeBe = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*suX61hMGukOeZpCmmzup2w");

public string ssCeCo;

public string ssCeBe;


public BitArray OptimizedAttributes;

public ST_ec742cc5ff3341e853c9929e75681fd0Structure() {
OptimizedAttributes = null;
ssCeCo = "";
ssCeBe = "";
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
ssCeCo = r.ReadText(index++, "UniquesCeBeCeCo.CeCo", "");
ssCeBe = r.ReadText(index++, "UniquesCeBeCeCo.CeBe", "");
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
public void ReadIM(ST_ec742cc5ff3341e853c9929e75681fd0Structure r) {
this = r;
}


public static bool operator == (ST_ec742cc5ff3341e853c9929e75681fd0Structure a, ST_ec742cc5ff3341e853c9929e75681fd0Structure b) {
if (a.ssCeCo != b.ssCeCo) return false;
if (a.ssCeBe != b.ssCeBe) return false;
return true;
}

public static bool operator != (ST_ec742cc5ff3341e853c9929e75681fd0Structure a, ST_ec742cc5ff3341e853c9929e75681fd0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ec742cc5ff3341e853c9929e75681fd0Structure)) return false;
return (this == (ST_ec742cc5ff3341e853c9929e75681fd0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCeCo.GetHashCode()
 ^ ssCeBe.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ec742cc5ff3341e853c9929e75681fd0Structure Duplicate() {
ST_ec742cc5ff3341e853c9929e75681fd0Structure t;
t.ssCeCo = this.ssCeCo;
t.ssCeBe = this.ssCeBe;
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
if (head == "ceco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeCo")) variable.Value = ssCeCo; else variable.Optimized = true;
} else if (head == "cebe") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeBe")) variable.Value = ssCeBe; else variable.Optimized = true;
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
if (key == IdCeCo) {
return ssCeCo;
}
if (key == IdCeBe) {
return ssCeBe;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCeCo.Key.AsGuid) {
return ssCeCo;
}
if (attributeKey == IdCeBe.Key.AsGuid) {
return ssCeBe;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCeCo = (string) other.AttributeGet(IdCeCo);
ssCeBe = (string) other.AttributeGet(IdCeBe);
}
} // ST_ec742cc5ff3341e853c9929e75681fd0Structure
/// <summary>
/// RecordList type <code>UniquesCeBeCeCoList</code> that represents a record list of
///  <code>UniquesCeBeCeCo</code>
/// </summary>
public partial class RL_9f4a06b9eee76e389b47126ac26c9cda : GenericRecordList<ST_ec742cc5ff3341e853c9929e75681fd0Structure>, IEnumerable, IEnumerator {

protected override ST_ec742cc5ff3341e853c9929e75681fd0Structure GetElementDefaultValue() {
return new ST_ec742cc5ff3341e853c9929e75681fd0Structure();
}

public T[] ToArray<T>(Func<ST_ec742cc5ff3341e853c9929e75681fd0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f4a06b9eee76e389b47126ac26c9cda recordList, Func<ST_ec742cc5ff3341e853c9929e75681fd0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f4a06b9eee76e389b47126ac26c9cda(ST_ec742cc5ff3341e853c9929e75681fd0Structure[] array) {
  RL_9f4a06b9eee76e389b47126ac26c9cda result = new RL_9f4a06b9eee76e389b47126ac26c9cda();
result.InnerFromArray(array);
    return result;
}

public static RL_9f4a06b9eee76e389b47126ac26c9cda ToList<T>(T[] array, Func <T, ST_ec742cc5ff3341e853c9929e75681fd0Structure> converter) {
  RL_9f4a06b9eee76e389b47126ac26c9cda result = new RL_9f4a06b9eee76e389b47126ac26c9cda();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f4a06b9eee76e389b47126ac26c9cda FromRestList<T>(RestList<T> restList, Func <T, ST_ec742cc5ff3341e853c9929e75681fd0Structure> converter) {
  RL_9f4a06b9eee76e389b47126ac26c9cda result = new RL_9f4a06b9eee76e389b47126ac26c9cda();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f4a06b9eee76e389b47126ac26c9cda() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ec742cc5ff3341e853c9929e75681fd0Structure> NewList() {
return new RL_9f4a06b9eee76e389b47126ac26c9cda();
}


} // RL_9f4a06b9eee76e389b47126ac26c9cda
}

