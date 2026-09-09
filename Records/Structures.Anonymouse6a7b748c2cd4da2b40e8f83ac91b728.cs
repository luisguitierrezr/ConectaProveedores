namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SLen5s3Cok20Do+DrJG3KA)
///  <code>RC_8bdff63e403435425d3da06733f0b39f</code> that represent
/// s <code>UserApplicationRoleTempRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserApplicationRoleTempRegionRecord
public partial struct RC_8bdff63e403435425d3da06733f0b39f : ITypedRecord<RC_8bdff63e403435425d3da06733f0b39f> {
internal static readonly GlobalObjectKey IdUserApplicationRoleTemp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kn3GZlFuC4xnPZEZ9i2hkw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord ssENUserApplicationRoleTemp;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_8bdff63e403435425d3da06733f0b39f() {
OptimizedAttributes = null;
ssENUserApplicationRoleTemp = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserApplicationRoleTemp.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUserApplicationRoleTemp.OptimizedAttributes = value[0];
    ssENRegion.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUserApplicationRoleTemp.OptimizedAttributes;
    all[1] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserApplicationRoleTemp.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_8bdff63e403435425d3da06733f0b39f r) {
this = r;
}


public static bool operator == (RC_8bdff63e403435425d3da06733f0b39f a, RC_8bdff63e403435425d3da06733f0b39f b) {
if (a.ssENUserApplicationRoleTemp != b.ssENUserApplicationRoleTemp) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_8bdff63e403435425d3da06733f0b39f a, RC_8bdff63e403435425d3da06733f0b39f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8bdff63e403435425d3da06733f0b39f)) return false;
return (this == (RC_8bdff63e403435425d3da06733f0b39f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserApplicationRoleTemp.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserApplicationRoleTemp.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserApplicationRoleTemp.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_8bdff63e403435425d3da06733f0b39f Duplicate() {
RC_8bdff63e403435425d3da06733f0b39f t;
t.ssENUserApplicationRoleTemp = (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)this.ssENUserApplicationRoleTemp.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "userapplicationroletemp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTemp")) variable.Value = ssENUserApplicationRoleTemp; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletemp");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdUserApplicationRoleTemp) {
return ssENUserApplicationRoleTemp;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserApplicationRoleTemp.Key.AsGuid) {
return ssENUserApplicationRoleTemp;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserApplicationRoleTemp.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTemp));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_8bdff63e403435425d3da06733f0b39f
/// <summary>
/// RecordList type <code>UserApplicationRoleTempRegionRecordList</code> that represents a record list
///  of <code>UserApplicationRoleTemp, Region</code>
/// </summary>
public partial class RL_b2a2d56548a1fac8cf05c6115bf4c826 : GenericRecordList<RC_8bdff63e403435425d3da06733f0b39f>, IEnumerable, IEnumerator {

protected override RC_8bdff63e403435425d3da06733f0b39f GetElementDefaultValue() {
return new RC_8bdff63e403435425d3da06733f0b39f();
}

public T[] ToArray<T>(Func<RC_8bdff63e403435425d3da06733f0b39f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b2a2d56548a1fac8cf05c6115bf4c826 recordList, Func<RC_8bdff63e403435425d3da06733f0b39f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b2a2d56548a1fac8cf05c6115bf4c826(RC_8bdff63e403435425d3da06733f0b39f[] array) {
  RL_b2a2d56548a1fac8cf05c6115bf4c826 result = new RL_b2a2d56548a1fac8cf05c6115bf4c826();
result.InnerFromArray(array);
    return result;
}

public static RL_b2a2d56548a1fac8cf05c6115bf4c826 ToList<T>(T[] array, Func <T, RC_8bdff63e403435425d3da06733f0b39f> converter) {
  RL_b2a2d56548a1fac8cf05c6115bf4c826 result = new RL_b2a2d56548a1fac8cf05c6115bf4c826();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b2a2d56548a1fac8cf05c6115bf4c826 FromRestList<T>(RestList<T> restList, Func <T, RC_8bdff63e403435425d3da06733f0b39f> converter) {
  RL_b2a2d56548a1fac8cf05c6115bf4c826 result = new RL_b2a2d56548a1fac8cf05c6115bf4c826();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b2a2d56548a1fac8cf05c6115bf4c826() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8bdff63e403435425d3da06733f0b39f> NewList() {
return new RL_b2a2d56548a1fac8cf05c6115bf4c826();
}


} // RL_b2a2d56548a1fac8cf05c6115bf4c826
}

