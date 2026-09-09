namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (JU4amJhu+EqYrwyLPkFkOA)
///  <code>RC_e6c76727dae2b3bb5ec75f08f3bfbb21</code> that represents <code>RoleStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RoleStatusRecord
public partial struct RC_e6c76727dae2b3bb5ec75f08f3bfbb21 : ITypedRecord<RC_e6c76727dae2b3bb5ec75f08f3bfbb21> {
internal static readonly GlobalObjectKey IdRoleStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*J2fH5uLau7Nex18I87+7IQ");

public EN_fee44a96be32c0c9f1bda470eac56718EntityRecord ssENRoleStatus;


public static implicit operator EN_fee44a96be32c0c9f1bda470eac56718EntityRecord( RC_e6c76727dae2b3bb5ec75f08f3bfbb21 r) {
return r.ssENRoleStatus;
}

public static implicit operator RC_e6c76727dae2b3bb5ec75f08f3bfbb21 (EN_fee44a96be32c0c9f1bda470eac56718EntityRecord r) {
RC_e6c76727dae2b3bb5ec75f08f3bfbb21 res = new RC_e6c76727dae2b3bb5ec75f08f3bfbb21 ();
res.ssENRoleStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRoleStatus.ChangedAttributes = value;
}
get {
    return ssENRoleStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e6c76727dae2b3bb5ec75f08f3bfbb21() {
OptimizedAttributes = null;
ssENRoleStatus = new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRoleStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRoleStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRoleStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRoleStatus.Read( r, ref index);
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
public void ReadIM(RC_e6c76727dae2b3bb5ec75f08f3bfbb21 r) {
this = r;
}


public static bool operator == (RC_e6c76727dae2b3bb5ec75f08f3bfbb21 a, RC_e6c76727dae2b3bb5ec75f08f3bfbb21 b) {
if (a.ssENRoleStatus != b.ssENRoleStatus) return false;
return true;
}

public static bool operator != (RC_e6c76727dae2b3bb5ec75f08f3bfbb21 a, RC_e6c76727dae2b3bb5ec75f08f3bfbb21 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e6c76727dae2b3bb5ec75f08f3bfbb21)) return false;
return (this == (RC_e6c76727dae2b3bb5ec75f08f3bfbb21)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRoleStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRoleStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRoleStatus.InternalRecursiveSave();
}


public RC_e6c76727dae2b3bb5ec75f08f3bfbb21 Duplicate() {
RC_e6c76727dae2b3bb5ec75f08f3bfbb21 t;
t.ssENRoleStatus = (EN_fee44a96be32c0c9f1bda470eac56718EntityRecord)this.ssENRoleStatus.Duplicate();
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
if (head == "rolestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleStatus")) variable.Value = ssENRoleStatus; else variable.Optimized = true;
variable.SetFieldName("rolestatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRoleStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRoleStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRoleStatus) {
return ssENRoleStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRoleStatus.Key.AsGuid) {
return ssENRoleStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRoleStatus.FillFromOther((IRecord) other.AttributeGet(IdRoleStatus));
}
} // RC_e6c76727dae2b3bb5ec75f08f3bfbb21
/// <summary>
/// RecordList type <code>RoleStatusRecordList</code> that represents a record list of
///  <code>RoleStatus</code>
/// </summary>
public partial class RL_bde5ba26b81c2104fd642c990a848dae : GenericRecordList<RC_e6c76727dae2b3bb5ec75f08f3bfbb21>, IEnumerable, IEnumerator {

protected override RC_e6c76727dae2b3bb5ec75f08f3bfbb21 GetElementDefaultValue() {
return new RC_e6c76727dae2b3bb5ec75f08f3bfbb21();
}

public T[] ToArray<T>(Func<RC_e6c76727dae2b3bb5ec75f08f3bfbb21, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bde5ba26b81c2104fd642c990a848dae recordList, Func<RC_e6c76727dae2b3bb5ec75f08f3bfbb21, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bde5ba26b81c2104fd642c990a848dae(RC_e6c76727dae2b3bb5ec75f08f3bfbb21[] array) {
  RL_bde5ba26b81c2104fd642c990a848dae result = new RL_bde5ba26b81c2104fd642c990a848dae();
result.InnerFromArray(array);
    return result;
}

public static RL_bde5ba26b81c2104fd642c990a848dae ToList<T>(T[] array, Func <T, RC_e6c76727dae2b3bb5ec75f08f3bfbb21> converter) {
  RL_bde5ba26b81c2104fd642c990a848dae result = new RL_bde5ba26b81c2104fd642c990a848dae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bde5ba26b81c2104fd642c990a848dae FromRestList<T>(RestList<T> restList, Func <T, RC_e6c76727dae2b3bb5ec75f08f3bfbb21> converter) {
  RL_bde5ba26b81c2104fd642c990a848dae result = new RL_bde5ba26b81c2104fd642c990a848dae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bde5ba26b81c2104fd642c990a848dae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e6c76727dae2b3bb5ec75f08f3bfbb21> NewList() {
return new RL_bde5ba26b81c2104fd642c990a848dae();
}


} // RL_bde5ba26b81c2104fd642c990a848dae
}

