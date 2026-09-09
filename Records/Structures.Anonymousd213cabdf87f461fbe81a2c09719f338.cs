namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vcoT0n_4H0a+gaLAlxnzOA)
///  <code>RC_85af8fa7a4c9fca4ade94e1edb0d5f7d</code> that represent
/// s <code>VideoOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: VideoOptionalConfigsRecord
public partial struct RC_85af8fa7a4c9fca4ade94e1edb0d5f7d : ITypedRecord<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> {
internal static readonly GlobalObjectKey IdVideoOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*p4+vhcmkpPyt6U4e2w1ffQ");

public ST_6510d2524fe77fcc6c285159d4000cfbStructure ssSTVideoOptionalConfigs;


public static implicit operator ST_6510d2524fe77fcc6c285159d4000cfbStructure( RC_85af8fa7a4c9fca4ade94e1edb0d5f7d r) {
return r.ssSTVideoOptionalConfigs;
}

public static implicit operator RC_85af8fa7a4c9fca4ade94e1edb0d5f7d (ST_6510d2524fe77fcc6c285159d4000cfbStructure r) {
RC_85af8fa7a4c9fca4ade94e1edb0d5f7d res = new RC_85af8fa7a4c9fca4ade94e1edb0d5f7d ();
res.ssSTVideoOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_85af8fa7a4c9fca4ade94e1edb0d5f7d() {
OptimizedAttributes = null;
ssSTVideoOptionalConfigs = new ST_6510d2524fe77fcc6c285159d4000cfbStructure();
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
    ssSTVideoOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTVideoOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_85af8fa7a4c9fca4ade94e1edb0d5f7d r) {
this = r;
}


public static bool operator == (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d a, RC_85af8fa7a4c9fca4ade94e1edb0d5f7d b) {
if (a.ssSTVideoOptionalConfigs != b.ssSTVideoOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d a, RC_85af8fa7a4c9fca4ade94e1edb0d5f7d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d)) return false;
return (this == (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTVideoOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTVideoOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTVideoOptionalConfigs.InternalRecursiveSave();
}


public RC_85af8fa7a4c9fca4ade94e1edb0d5f7d Duplicate() {
RC_85af8fa7a4c9fca4ade94e1edb0d5f7d t;
t.ssSTVideoOptionalConfigs = (ST_6510d2524fe77fcc6c285159d4000cfbStructure)this.ssSTVideoOptionalConfigs.Duplicate();
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
if (head == "videooptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VideoOptionalConfigs")) variable.Value = ssSTVideoOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("videooptionalconfigs");
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
if (key == IdVideoOptionalConfigs) {
return ssSTVideoOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVideoOptionalConfigs.Key.AsGuid) {
return ssSTVideoOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTVideoOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdVideoOptionalConfigs));
}
} // RC_85af8fa7a4c9fca4ade94e1edb0d5f7d
/// <summary>
/// RecordList type <code>VideoOptionalConfigsRecordList</code> that represents a record list of
///  <code>VideoOptionalConfigs</code>
/// </summary>
public partial class RL_7a204c55a54d7fc5a49ee67743d390cb : GenericRecordList<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d>, IEnumerable, IEnumerator {

protected override RC_85af8fa7a4c9fca4ade94e1edb0d5f7d GetElementDefaultValue() {
return new RC_85af8fa7a4c9fca4ade94e1edb0d5f7d();
}

public T[] ToArray<T>(Func<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7a204c55a54d7fc5a49ee67743d390cb recordList, Func<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7a204c55a54d7fc5a49ee67743d390cb(RC_85af8fa7a4c9fca4ade94e1edb0d5f7d[] array) {
  RL_7a204c55a54d7fc5a49ee67743d390cb result = new RL_7a204c55a54d7fc5a49ee67743d390cb();
result.InnerFromArray(array);
    return result;
}

public static RL_7a204c55a54d7fc5a49ee67743d390cb ToList<T>(T[] array, Func <T, RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> converter) {
  RL_7a204c55a54d7fc5a49ee67743d390cb result = new RL_7a204c55a54d7fc5a49ee67743d390cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7a204c55a54d7fc5a49ee67743d390cb FromRestList<T>(RestList<T> restList, Func <T, RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> converter) {
  RL_7a204c55a54d7fc5a49ee67743d390cb result = new RL_7a204c55a54d7fc5a49ee67743d390cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7a204c55a54d7fc5a49ee67743d390cb() : base() {
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
protected override OSList<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> NewList() {
return new RL_7a204c55a54d7fc5a49ee67743d390cb();
}


} // RL_7a204c55a54d7fc5a49ee67743d390cb
}

