namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZlftbfCmME+GzhNKJzK02Q)
///  <code>RC_83bc3ae4c5fec64bfa528e6320384107</code> that represents <code>OptionalConfigsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OptionalConfigsRecord
public partial struct RC_83bc3ae4c5fec64bfa528e6320384107 : ITypedRecord<RC_83bc3ae4c5fec64bfa528e6320384107> {
internal static readonly GlobalObjectKey IdOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5Dq8g_7FS8b6Uo5jIDhBBw");

public ST_d907e71360b734aa1ce657185862bd8bStructure ssSTOptionalConfigs;


public static implicit operator ST_d907e71360b734aa1ce657185862bd8bStructure( RC_83bc3ae4c5fec64bfa528e6320384107 r) {
return r.ssSTOptionalConfigs;
}

public static implicit operator RC_83bc3ae4c5fec64bfa528e6320384107 (ST_d907e71360b734aa1ce657185862bd8bStructure r) {
RC_83bc3ae4c5fec64bfa528e6320384107 res = new RC_83bc3ae4c5fec64bfa528e6320384107 ();
res.ssSTOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_83bc3ae4c5fec64bfa528e6320384107() {
OptimizedAttributes = null;
ssSTOptionalConfigs = new ST_d907e71360b734aa1ce657185862bd8bStructure();
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
    ssSTOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_83bc3ae4c5fec64bfa528e6320384107 r) {
this = r;
}


public static bool operator == (RC_83bc3ae4c5fec64bfa528e6320384107 a, RC_83bc3ae4c5fec64bfa528e6320384107 b) {
if (a.ssSTOptionalConfigs != b.ssSTOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_83bc3ae4c5fec64bfa528e6320384107 a, RC_83bc3ae4c5fec64bfa528e6320384107 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_83bc3ae4c5fec64bfa528e6320384107)) return false;
return (this == (RC_83bc3ae4c5fec64bfa528e6320384107)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalConfigs.InternalRecursiveSave();
}


public RC_83bc3ae4c5fec64bfa528e6320384107 Duplicate() {
RC_83bc3ae4c5fec64bfa528e6320384107 t;
t.ssSTOptionalConfigs = (ST_d907e71360b734aa1ce657185862bd8bStructure)this.ssSTOptionalConfigs.Duplicate();
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
if (head == "optionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalConfigs")) variable.Value = ssSTOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalconfigs");
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
if (key == IdOptionalConfigs) {
return ssSTOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalConfigs.Key.AsGuid) {
return ssSTOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalConfigs));
}
} // RC_83bc3ae4c5fec64bfa528e6320384107
/// <summary>
/// RecordList type <code>OptionalConfigsRecordList</code> that represents a record list of
///  <code>OptionalConfigs</code>
/// </summary>
public partial class RL_7b71eb0202a2720df0d42d26f6b82001 : GenericRecordList<RC_83bc3ae4c5fec64bfa528e6320384107>, IEnumerable, IEnumerator {

protected override RC_83bc3ae4c5fec64bfa528e6320384107 GetElementDefaultValue() {
return new RC_83bc3ae4c5fec64bfa528e6320384107();
}

public T[] ToArray<T>(Func<RC_83bc3ae4c5fec64bfa528e6320384107, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b71eb0202a2720df0d42d26f6b82001 recordList, Func<RC_83bc3ae4c5fec64bfa528e6320384107, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b71eb0202a2720df0d42d26f6b82001(RC_83bc3ae4c5fec64bfa528e6320384107[] array) {
  RL_7b71eb0202a2720df0d42d26f6b82001 result = new RL_7b71eb0202a2720df0d42d26f6b82001();
result.InnerFromArray(array);
    return result;
}

public static RL_7b71eb0202a2720df0d42d26f6b82001 ToList<T>(T[] array, Func <T, RC_83bc3ae4c5fec64bfa528e6320384107> converter) {
  RL_7b71eb0202a2720df0d42d26f6b82001 result = new RL_7b71eb0202a2720df0d42d26f6b82001();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b71eb0202a2720df0d42d26f6b82001 FromRestList<T>(RestList<T> restList, Func <T, RC_83bc3ae4c5fec64bfa528e6320384107> converter) {
  RL_7b71eb0202a2720df0d42d26f6b82001 result = new RL_7b71eb0202a2720df0d42d26f6b82001();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b71eb0202a2720df0d42d26f6b82001() : base() {
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
protected override OSList<RC_83bc3ae4c5fec64bfa528e6320384107> NewList() {
return new RL_7b71eb0202a2720df0d42d26f6b82001();
}


} // RL_7b71eb0202a2720df0d42d26f6b82001
}

