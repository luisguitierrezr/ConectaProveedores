namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VzFqIx0tAE62Y3qpwENDHg)
///  <code>RC_b644f30294f981dde9a2d54c91ae805a</code> that represent
/// s <code>OrderRequestFileOrderContractFileOrderFileRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileOrderContractFileOrderFileRecord
public partial struct RC_b644f30294f981dde9a2d54c91ae805a : ITypedRecord<RC_b644f30294f981dde9a2d54c91ae805a> {
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;


public BitArray OptimizedAttributes;

public RC_b644f30294f981dde9a2d54c91ae805a() {
OptimizedAttributes = null;
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(17,false);
    all[1] = new BitArray(14,false);
    all[2] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderRequestFile.OptimizedAttributes = value[0];
    ssENOrderContractFile.OptimizedAttributes = value[1];
    ssENOrderFile.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderRequestFile.OptimizedAttributes;
    all[1] = ssENOrderContractFile.OptimizedAttributes;
    all[2] = ssENOrderFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFile.Read( r, ref index);
ssENOrderContractFile.Read( r, ref index);
ssENOrderFile.Read( r, ref index);
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
public void ReadIM(RC_b644f30294f981dde9a2d54c91ae805a r) {
this = r;
}


public static bool operator == (RC_b644f30294f981dde9a2d54c91ae805a a, RC_b644f30294f981dde9a2d54c91ae805a b) {
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
if (a.ssENOrderFile != b.ssENOrderFile) return false;
return true;
}

public static bool operator != (RC_b644f30294f981dde9a2d54c91ae805a a, RC_b644f30294f981dde9a2d54c91ae805a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b644f30294f981dde9a2d54c91ae805a)) return false;
return (this == (RC_b644f30294f981dde9a2d54c91ae805a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFile.RecursiveReset();
ssENOrderContractFile.RecursiveReset();
ssENOrderFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderContractFile.InternalRecursiveSave();
ssENOrderFile.InternalRecursiveSave();
}


public RC_b644f30294f981dde9a2d54c91ae805a Duplicate() {
RC_b644f30294f981dde9a2d54c91ae805a t;
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
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
if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
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
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderContractFile) {
return ssENOrderContractFile;
}
if (key == IdOrderFile) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
}
} // RC_b644f30294f981dde9a2d54c91ae805a
/// <summary>
/// RecordList type <code>OrderRequestFileOrderContractFileOrderFileRecordList</code> that represents a
///  record list of <code>OrderRequestFile, OrderContractFile, OrderFile</code>
/// </summary>
public partial class RL_b8e5e5391cd2f4a8007734ea06b758a8 : GenericRecordList<RC_b644f30294f981dde9a2d54c91ae805a>, IEnumerable, IEnumerator {

protected override RC_b644f30294f981dde9a2d54c91ae805a GetElementDefaultValue() {
return new RC_b644f30294f981dde9a2d54c91ae805a();
}

public T[] ToArray<T>(Func<RC_b644f30294f981dde9a2d54c91ae805a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b8e5e5391cd2f4a8007734ea06b758a8 recordList, Func<RC_b644f30294f981dde9a2d54c91ae805a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b8e5e5391cd2f4a8007734ea06b758a8(RC_b644f30294f981dde9a2d54c91ae805a[] array) {
  RL_b8e5e5391cd2f4a8007734ea06b758a8 result = new RL_b8e5e5391cd2f4a8007734ea06b758a8();
result.InnerFromArray(array);
    return result;
}

public static RL_b8e5e5391cd2f4a8007734ea06b758a8 ToList<T>(T[] array, Func <T, RC_b644f30294f981dde9a2d54c91ae805a> converter) {
  RL_b8e5e5391cd2f4a8007734ea06b758a8 result = new RL_b8e5e5391cd2f4a8007734ea06b758a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b8e5e5391cd2f4a8007734ea06b758a8 FromRestList<T>(RestList<T> restList, Func <T, RC_b644f30294f981dde9a2d54c91ae805a> converter) {
  RL_b8e5e5391cd2f4a8007734ea06b758a8 result = new RL_b8e5e5391cd2f4a8007734ea06b758a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b8e5e5391cd2f4a8007734ea06b758a8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(17,false);
def[1] = new BitArray(14,false);
def[2] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b644f30294f981dde9a2d54c91ae805a> NewList() {
return new RL_b8e5e5391cd2f4a8007734ea06b758a8();
}


} // RL_b8e5e5391cd2f4a8007734ea06b758a8
}

