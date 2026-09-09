namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (xknh4yEIlUqne454DYp34g)
///  <code>RC_aa950ad3dd0235488db9d65307673199</code> that represents <code>OrderLogsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderLogsRecord
public partial struct RC_aa950ad3dd0235488db9d65307673199 : ITypedRecord<RC_aa950ad3dd0235488db9d65307673199> {
internal static readonly GlobalObjectKey IdOrderLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0wqVqgLdSDWNudZTB2cxmQ");

public EN_a8e484428097204171df8a1feecb2534EntityRecord ssENOrderLogs;


public static implicit operator EN_a8e484428097204171df8a1feecb2534EntityRecord( RC_aa950ad3dd0235488db9d65307673199 r) {
return r.ssENOrderLogs;
}

public static implicit operator RC_aa950ad3dd0235488db9d65307673199 (EN_a8e484428097204171df8a1feecb2534EntityRecord r) {
RC_aa950ad3dd0235488db9d65307673199 res = new RC_aa950ad3dd0235488db9d65307673199 ();
res.ssENOrderLogs = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderLogs.ChangedAttributes = value;
}
get {
    return ssENOrderLogs.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_aa950ad3dd0235488db9d65307673199() {
OptimizedAttributes = null;
ssENOrderLogs = new EN_a8e484428097204171df8a1feecb2534EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderLogs.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderLogs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderLogs.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderLogs.Read( r, ref index);
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
public void ReadIM(RC_aa950ad3dd0235488db9d65307673199 r) {
this = r;
}


public static bool operator == (RC_aa950ad3dd0235488db9d65307673199 a, RC_aa950ad3dd0235488db9d65307673199 b) {
if (a.ssENOrderLogs != b.ssENOrderLogs) return false;
return true;
}

public static bool operator != (RC_aa950ad3dd0235488db9d65307673199 a, RC_aa950ad3dd0235488db9d65307673199 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aa950ad3dd0235488db9d65307673199)) return false;
return (this == (RC_aa950ad3dd0235488db9d65307673199)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderLogs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderLogs.InternalRecursiveSave();
}


public RC_aa950ad3dd0235488db9d65307673199 Duplicate() {
RC_aa950ad3dd0235488db9d65307673199 t;
t.ssENOrderLogs = (EN_a8e484428097204171df8a1feecb2534EntityRecord)this.ssENOrderLogs.Duplicate();
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
if (head == "orderlogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderLogs")) variable.Value = ssENOrderLogs; else variable.Optimized = true;
variable.SetFieldName("orderlogs");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderLogs.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderLogs.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderLogs) {
return ssENOrderLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderLogs.Key.AsGuid) {
return ssENOrderLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderLogs.FillFromOther((IRecord) other.AttributeGet(IdOrderLogs));
}
} // RC_aa950ad3dd0235488db9d65307673199
/// <summary>
/// RecordList type <code>OrderLogsRecordList</code> that represents a record list of
///  <code>OrderLogs</code>
/// </summary>
public partial class RL_2ff7502185db3c03acfc62a4b98a3a5f : GenericRecordList<RC_aa950ad3dd0235488db9d65307673199>, IEnumerable, IEnumerator {

protected override RC_aa950ad3dd0235488db9d65307673199 GetElementDefaultValue() {
return new RC_aa950ad3dd0235488db9d65307673199();
}

public T[] ToArray<T>(Func<RC_aa950ad3dd0235488db9d65307673199, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2ff7502185db3c03acfc62a4b98a3a5f recordList, Func<RC_aa950ad3dd0235488db9d65307673199, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2ff7502185db3c03acfc62a4b98a3a5f(RC_aa950ad3dd0235488db9d65307673199[] array) {
  RL_2ff7502185db3c03acfc62a4b98a3a5f result = new RL_2ff7502185db3c03acfc62a4b98a3a5f();
result.InnerFromArray(array);
    return result;
}

public static RL_2ff7502185db3c03acfc62a4b98a3a5f ToList<T>(T[] array, Func <T, RC_aa950ad3dd0235488db9d65307673199> converter) {
  RL_2ff7502185db3c03acfc62a4b98a3a5f result = new RL_2ff7502185db3c03acfc62a4b98a3a5f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2ff7502185db3c03acfc62a4b98a3a5f FromRestList<T>(RestList<T> restList, Func <T, RC_aa950ad3dd0235488db9d65307673199> converter) {
  RL_2ff7502185db3c03acfc62a4b98a3a5f result = new RL_2ff7502185db3c03acfc62a4b98a3a5f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2ff7502185db3c03acfc62a4b98a3a5f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_aa950ad3dd0235488db9d65307673199> NewList() {
return new RL_2ff7502185db3c03acfc62a4b98a3a5f();
}


} // RL_2ff7502185db3c03acfc62a4b98a3a5f
}

