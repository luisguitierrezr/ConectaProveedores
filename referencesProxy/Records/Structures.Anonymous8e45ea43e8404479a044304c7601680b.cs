namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Q+pFjkDoeUSgRDBMdgFoCw)
///  <code>RC_b7283e2c6e9c6bcb5286d1ae04959554</code> that represent
/// s <code>TabsOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: TabsOptionalConfigsRecord
public partial struct RC_b7283e2c6e9c6bcb5286d1ae04959554 : ITypedRecord<RC_b7283e2c6e9c6bcb5286d1ae04959554> {
internal static readonly GlobalObjectKey IdTabsOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LD4ot5xuy2tShtGuBJWVVA");

public ST_e3f9af4171d5e4a41700770295d05c77Structure ssSTTabsOptionalConfigs;


public static implicit operator ST_e3f9af4171d5e4a41700770295d05c77Structure( RC_b7283e2c6e9c6bcb5286d1ae04959554 r) {
return r.ssSTTabsOptionalConfigs;
}

public static implicit operator RC_b7283e2c6e9c6bcb5286d1ae04959554 (ST_e3f9af4171d5e4a41700770295d05c77Structure r) {
RC_b7283e2c6e9c6bcb5286d1ae04959554 res = new RC_b7283e2c6e9c6bcb5286d1ae04959554 ();
res.ssSTTabsOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b7283e2c6e9c6bcb5286d1ae04959554() {
OptimizedAttributes = null;
ssSTTabsOptionalConfigs = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
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
    ssSTTabsOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTTabsOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_b7283e2c6e9c6bcb5286d1ae04959554 r) {
this = r;
}


public static bool operator == (RC_b7283e2c6e9c6bcb5286d1ae04959554 a, RC_b7283e2c6e9c6bcb5286d1ae04959554 b) {
if (a.ssSTTabsOptionalConfigs != b.ssSTTabsOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_b7283e2c6e9c6bcb5286d1ae04959554 a, RC_b7283e2c6e9c6bcb5286d1ae04959554 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b7283e2c6e9c6bcb5286d1ae04959554)) return false;
return (this == (RC_b7283e2c6e9c6bcb5286d1ae04959554)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTabsOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTabsOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTabsOptionalConfigs.InternalRecursiveSave();
}


public RC_b7283e2c6e9c6bcb5286d1ae04959554 Duplicate() {
RC_b7283e2c6e9c6bcb5286d1ae04959554 t;
t.ssSTTabsOptionalConfigs = (ST_e3f9af4171d5e4a41700770295d05c77Structure)this.ssSTTabsOptionalConfigs.Duplicate();
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
if (head == "tabsoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabsOptionalConfigs")) variable.Value = ssSTTabsOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("tabsoptionalconfigs");
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
if (key == IdTabsOptionalConfigs) {
return ssSTTabsOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTabsOptionalConfigs.Key.AsGuid) {
return ssSTTabsOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTabsOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdTabsOptionalConfigs));
}
} // RC_b7283e2c6e9c6bcb5286d1ae04959554
/// <summary>
/// RecordList type <code>TabsOptionalConfigsRecordList</code> that represents a record list of
///  <code>TabsOptionalConfigs</code>
/// </summary>
public partial class RL_9e12f04bf3ce19087cbbf62097a9932a : GenericRecordList<RC_b7283e2c6e9c6bcb5286d1ae04959554>, IEnumerable, IEnumerator {

protected override RC_b7283e2c6e9c6bcb5286d1ae04959554 GetElementDefaultValue() {
return new RC_b7283e2c6e9c6bcb5286d1ae04959554();
}

public T[] ToArray<T>(Func<RC_b7283e2c6e9c6bcb5286d1ae04959554, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e12f04bf3ce19087cbbf62097a9932a recordList, Func<RC_b7283e2c6e9c6bcb5286d1ae04959554, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e12f04bf3ce19087cbbf62097a9932a(RC_b7283e2c6e9c6bcb5286d1ae04959554[] array) {
  RL_9e12f04bf3ce19087cbbf62097a9932a result = new RL_9e12f04bf3ce19087cbbf62097a9932a();
result.InnerFromArray(array);
    return result;
}

public static RL_9e12f04bf3ce19087cbbf62097a9932a ToList<T>(T[] array, Func <T, RC_b7283e2c6e9c6bcb5286d1ae04959554> converter) {
  RL_9e12f04bf3ce19087cbbf62097a9932a result = new RL_9e12f04bf3ce19087cbbf62097a9932a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e12f04bf3ce19087cbbf62097a9932a FromRestList<T>(RestList<T> restList, Func <T, RC_b7283e2c6e9c6bcb5286d1ae04959554> converter) {
  RL_9e12f04bf3ce19087cbbf62097a9932a result = new RL_9e12f04bf3ce19087cbbf62097a9932a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e12f04bf3ce19087cbbf62097a9932a() : base() {
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
protected override OSList<RC_b7283e2c6e9c6bcb5286d1ae04959554> NewList() {
return new RL_9e12f04bf3ce19087cbbf62097a9932a();
}


} // RL_9e12f04bf3ce19087cbbf62097a9932a
}

