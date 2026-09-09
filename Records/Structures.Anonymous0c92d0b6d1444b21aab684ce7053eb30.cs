namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ttCSDETRIUuqtoTOcFPrMA)
///  <code>RC_53b91594846c82c8b6761c8e124bc2f9</code> that represents <code>RoleNameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RoleNameRecord
public partial struct RC_53b91594846c82c8b6761c8e124bc2f9 : ITypedRecord<RC_53b91594846c82c8b6761c8e124bc2f9> {
internal static readonly GlobalObjectKey IdRoleName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lBW5U2yEyIK2dhyOEkvC+Q");

public string ssRoleName;


public BitArray OptimizedAttributes;

public RC_53b91594846c82c8b6761c8e124bc2f9() {
OptimizedAttributes = null;
ssRoleName = "";
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
ssRoleName = r.ReadText(index++, "RoleNameRecord.RoleName", "");
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
public void ReadIM(RC_53b91594846c82c8b6761c8e124bc2f9 r) {
this = r;
}


public static bool operator == (RC_53b91594846c82c8b6761c8e124bc2f9 a, RC_53b91594846c82c8b6761c8e124bc2f9 b) {
if (a.ssRoleName != b.ssRoleName) return false;
return true;
}

public static bool operator != (RC_53b91594846c82c8b6761c8e124bc2f9 a, RC_53b91594846c82c8b6761c8e124bc2f9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53b91594846c82c8b6761c8e124bc2f9)) return false;
return (this == (RC_53b91594846c82c8b6761c8e124bc2f9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRoleName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_53b91594846c82c8b6761c8e124bc2f9 Duplicate() {
RC_53b91594846c82c8b6761c8e124bc2f9 t;
t.ssRoleName = this.ssRoleName;
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
if (head == "rolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleName")) variable.Value = ssRoleName; else variable.Optimized = true;
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
if (key == IdRoleName) {
return ssRoleName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRoleName.Key.AsGuid) {
return ssRoleName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRoleName = (string) other.AttributeGet(IdRoleName);
}
} // RC_53b91594846c82c8b6761c8e124bc2f9
/// <summary>
/// RecordList type <code>RoleNameRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_7ee55cfd657529e0c1a187beec22d18a : GenericRecordList<RC_53b91594846c82c8b6761c8e124bc2f9>, IEnumerable, IEnumerator {

protected override RC_53b91594846c82c8b6761c8e124bc2f9 GetElementDefaultValue() {
return new RC_53b91594846c82c8b6761c8e124bc2f9();
}

public T[] ToArray<T>(Func<RC_53b91594846c82c8b6761c8e124bc2f9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7ee55cfd657529e0c1a187beec22d18a recordList, Func<RC_53b91594846c82c8b6761c8e124bc2f9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7ee55cfd657529e0c1a187beec22d18a(RC_53b91594846c82c8b6761c8e124bc2f9[] array) {
  RL_7ee55cfd657529e0c1a187beec22d18a result = new RL_7ee55cfd657529e0c1a187beec22d18a();
result.InnerFromArray(array);
    return result;
}

public static RL_7ee55cfd657529e0c1a187beec22d18a ToList<T>(T[] array, Func <T, RC_53b91594846c82c8b6761c8e124bc2f9> converter) {
  RL_7ee55cfd657529e0c1a187beec22d18a result = new RL_7ee55cfd657529e0c1a187beec22d18a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7ee55cfd657529e0c1a187beec22d18a FromRestList<T>(RestList<T> restList, Func <T, RC_53b91594846c82c8b6761c8e124bc2f9> converter) {
  RL_7ee55cfd657529e0c1a187beec22d18a result = new RL_7ee55cfd657529e0c1a187beec22d18a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7ee55cfd657529e0c1a187beec22d18a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_53b91594846c82c8b6761c8e124bc2f9> NewList() {
return new RL_7ee55cfd657529e0c1a187beec22d18a();
}


} // RL_7ee55cfd657529e0c1a187beec22d18a
}

