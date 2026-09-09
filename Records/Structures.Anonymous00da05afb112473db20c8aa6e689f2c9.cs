namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rwXaABKxPUeyDIqm5onyyQ)
///  <code>RC_61508c4f51e53175a4e20d5c4af9d10b</code> that represents <code>ItemEMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemEMRecord
public partial struct RC_61508c4f51e53175a4e20d5c4af9d10b : ITypedRecord<RC_61508c4f51e53175a4e20d5c4af9d10b> {
internal static readonly GlobalObjectKey IdItemEM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T4xQYeVRdTGk4g1cSvnRCw");

public ST_6a8665543a0f720f26db84a82f35885fStructure ssSTItemEM;


public static implicit operator ST_6a8665543a0f720f26db84a82f35885fStructure( RC_61508c4f51e53175a4e20d5c4af9d10b r) {
return r.ssSTItemEM;
}

public static implicit operator RC_61508c4f51e53175a4e20d5c4af9d10b (ST_6a8665543a0f720f26db84a82f35885fStructure r) {
RC_61508c4f51e53175a4e20d5c4af9d10b res = new RC_61508c4f51e53175a4e20d5c4af9d10b ();
res.ssSTItemEM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_61508c4f51e53175a4e20d5c4af9d10b() {
OptimizedAttributes = null;
ssSTItemEM = new ST_6a8665543a0f720f26db84a82f35885fStructure();
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
    ssSTItemEM.OptimizedAttributes = value[0];
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
ssSTItemEM.Read( r, ref index);
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
public void ReadIM(RC_61508c4f51e53175a4e20d5c4af9d10b r) {
this = r;
}


public static bool operator == (RC_61508c4f51e53175a4e20d5c4af9d10b a, RC_61508c4f51e53175a4e20d5c4af9d10b b) {
if (a.ssSTItemEM != b.ssSTItemEM) return false;
return true;
}

public static bool operator != (RC_61508c4f51e53175a4e20d5c4af9d10b a, RC_61508c4f51e53175a4e20d5c4af9d10b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_61508c4f51e53175a4e20d5c4af9d10b)) return false;
return (this == (RC_61508c4f51e53175a4e20d5c4af9d10b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemEM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemEM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemEM.InternalRecursiveSave();
}


public RC_61508c4f51e53175a4e20d5c4af9d10b Duplicate() {
RC_61508c4f51e53175a4e20d5c4af9d10b t;
t.ssSTItemEM = (ST_6a8665543a0f720f26db84a82f35885fStructure)this.ssSTItemEM.Duplicate();
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
if (head == "itemem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemEM")) variable.Value = ssSTItemEM; else variable.Optimized = true;
variable.SetFieldName("itemem");
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
if (key == IdItemEM) {
return ssSTItemEM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemEM.Key.AsGuid) {
return ssSTItemEM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemEM.FillFromOther((IRecord) other.AttributeGet(IdItemEM));
}
} // RC_61508c4f51e53175a4e20d5c4af9d10b
/// <summary>
/// RecordList type <code>ItemEMRecordList</code> that represents a record list of <code>ItemEM</code>
/// </summary>
public partial class RL_e14827c31071b6f2c8e6154e61cdd346 : GenericRecordList<RC_61508c4f51e53175a4e20d5c4af9d10b>, IEnumerable, IEnumerator {

protected override RC_61508c4f51e53175a4e20d5c4af9d10b GetElementDefaultValue() {
return new RC_61508c4f51e53175a4e20d5c4af9d10b();
}

public T[] ToArray<T>(Func<RC_61508c4f51e53175a4e20d5c4af9d10b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e14827c31071b6f2c8e6154e61cdd346 recordList, Func<RC_61508c4f51e53175a4e20d5c4af9d10b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e14827c31071b6f2c8e6154e61cdd346(RC_61508c4f51e53175a4e20d5c4af9d10b[] array) {
  RL_e14827c31071b6f2c8e6154e61cdd346 result = new RL_e14827c31071b6f2c8e6154e61cdd346();
result.InnerFromArray(array);
    return result;
}

public static RL_e14827c31071b6f2c8e6154e61cdd346 ToList<T>(T[] array, Func <T, RC_61508c4f51e53175a4e20d5c4af9d10b> converter) {
  RL_e14827c31071b6f2c8e6154e61cdd346 result = new RL_e14827c31071b6f2c8e6154e61cdd346();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e14827c31071b6f2c8e6154e61cdd346 FromRestList<T>(RestList<T> restList, Func <T, RC_61508c4f51e53175a4e20d5c4af9d10b> converter) {
  RL_e14827c31071b6f2c8e6154e61cdd346 result = new RL_e14827c31071b6f2c8e6154e61cdd346();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e14827c31071b6f2c8e6154e61cdd346() : base() {
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
protected override OSList<RC_61508c4f51e53175a4e20d5c4af9d10b> NewList() {
return new RL_e14827c31071b6f2c8e6154e61cdd346();
}


} // RL_e14827c31071b6f2c8e6154e61cdd346
}

