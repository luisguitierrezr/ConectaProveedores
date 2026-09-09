namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (a5xnq+mb5EChvV0o9FS9Ag)
///  <code>RC_e1a5e242516e79b9390b0e4c2ab2f5cc</code> that represents <code>EnvironmentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EnvironmentRecord
public partial struct RC_e1a5e242516e79b9390b0e4c2ab2f5cc : ITypedRecord<RC_e1a5e242516e79b9390b0e4c2ab2f5cc>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdEnvironment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QuKl4W5RuXk5Cw5MKrL1zA");

public ST_201dce7bb255178c132fec4d547942aeStructure ssSTEnvironment;


public static implicit operator ST_201dce7bb255178c132fec4d547942aeStructure( RC_e1a5e242516e79b9390b0e4c2ab2f5cc r) {
return r.ssSTEnvironment;
}

public static implicit operator RC_e1a5e242516e79b9390b0e4c2ab2f5cc (ST_201dce7bb255178c132fec4d547942aeStructure r) {
RC_e1a5e242516e79b9390b0e4c2ab2f5cc res = new RC_e1a5e242516e79b9390b0e4c2ab2f5cc ();
res.ssSTEnvironment = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e1a5e242516e79b9390b0e4c2ab2f5cc() {
OptimizedAttributes = null;
ssSTEnvironment = new ST_201dce7bb255178c132fec4d547942aeStructure();
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
    ssSTEnvironment.OptimizedAttributes = value[0];
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
ssSTEnvironment.Read( r, ref index);
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
public void ReadIM(RC_e1a5e242516e79b9390b0e4c2ab2f5cc r) {
this = r;
}


public static bool operator == (RC_e1a5e242516e79b9390b0e4c2ab2f5cc a, RC_e1a5e242516e79b9390b0e4c2ab2f5cc b) {
if (a.ssSTEnvironment != b.ssSTEnvironment) return false;
return true;
}

public static bool operator != (RC_e1a5e242516e79b9390b0e4c2ab2f5cc a, RC_e1a5e242516e79b9390b0e4c2ab2f5cc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e1a5e242516e79b9390b0e4c2ab2f5cc)) return false;
return (this == (RC_e1a5e242516e79b9390b0e4c2ab2f5cc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEnvironment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEnvironment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEnvironment.InternalRecursiveSave();
}


public RC_e1a5e242516e79b9390b0e4c2ab2f5cc Duplicate() {
RC_e1a5e242516e79b9390b0e4c2ab2f5cc t;
t.ssSTEnvironment = (ST_201dce7bb255178c132fec4d547942aeStructure)this.ssSTEnvironment.Duplicate();
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
if (head == "environment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Environment")) variable.Value = ssSTEnvironment; else variable.Optimized = true;
variable.SetFieldName("environment");
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
if (key == IdEnvironment) {
return ssSTEnvironment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEnvironment.Key.AsGuid) {
return ssSTEnvironment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEnvironment.FillFromOther((IRecord) other.AttributeGet(IdEnvironment));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTEnvironment.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdEnvironment.Key.AsGuid));
}
} // RC_e1a5e242516e79b9390b0e4c2ab2f5cc
/// <summary>
/// RecordList type <code>EnvironmentRecordList</code> that represents a record list of
///  <code>Environment</code>
/// </summary>
public partial class RL_16a1a07379f659e663e20b0d5819b0cd : GenericRecordList<RC_e1a5e242516e79b9390b0e4c2ab2f5cc>, IEnumerable, IEnumerator {

protected override RC_e1a5e242516e79b9390b0e4c2ab2f5cc GetElementDefaultValue() {
return new RC_e1a5e242516e79b9390b0e4c2ab2f5cc();
}

public T[] ToArray<T>(Func<RC_e1a5e242516e79b9390b0e4c2ab2f5cc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_16a1a07379f659e663e20b0d5819b0cd recordList, Func<RC_e1a5e242516e79b9390b0e4c2ab2f5cc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_16a1a07379f659e663e20b0d5819b0cd(RC_e1a5e242516e79b9390b0e4c2ab2f5cc[] array) {
  RL_16a1a07379f659e663e20b0d5819b0cd result = new RL_16a1a07379f659e663e20b0d5819b0cd();
result.InnerFromArray(array);
    return result;
}

public static RL_16a1a07379f659e663e20b0d5819b0cd ToList<T>(T[] array, Func <T, RC_e1a5e242516e79b9390b0e4c2ab2f5cc> converter) {
  RL_16a1a07379f659e663e20b0d5819b0cd result = new RL_16a1a07379f659e663e20b0d5819b0cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_16a1a07379f659e663e20b0d5819b0cd FromRestList<T>(RestList<T> restList, Func <T, RC_e1a5e242516e79b9390b0e4c2ab2f5cc> converter) {
  RL_16a1a07379f659e663e20b0d5819b0cd result = new RL_16a1a07379f659e663e20b0d5819b0cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_16a1a07379f659e663e20b0d5819b0cd() : base() {
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
protected override OSList<RC_e1a5e242516e79b9390b0e4c2ab2f5cc> NewList() {
return new RL_16a1a07379f659e663e20b0d5819b0cd();
}


} // RL_16a1a07379f659e663e20b0d5819b0cd
}

