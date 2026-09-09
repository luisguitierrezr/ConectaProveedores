namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ixcWIftiDEKeYgwJReE_XQ)
///  <code>RC_daa6040aa65b55c2574e6a4e976766ce</code> that represent
/// s <code>OrderRequestFileApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileApprovalLevelRecord
public partial struct RC_daa6040aa65b55c2574e6a4e976766ce : ITypedRecord<RC_daa6040aa65b55c2574e6a4e976766ce> {
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CgSm2lumwlVXTmpOl2dmzg");

public EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel;


public static implicit operator EN_80af67ecab8f43d464cc57955285a024EntityRecord( RC_daa6040aa65b55c2574e6a4e976766ce r) {
return r.ssENOrderRequestFileApprovalLevel;
}

public static implicit operator RC_daa6040aa65b55c2574e6a4e976766ce (EN_80af67ecab8f43d464cc57955285a024EntityRecord r) {
RC_daa6040aa65b55c2574e6a4e976766ce res = new RC_daa6040aa65b55c2574e6a4e976766ce ();
res.ssENOrderRequestFileApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderRequestFileApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENOrderRequestFileApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_daa6040aa65b55c2574e6a4e976766ce() {
OptimizedAttributes = null;
ssENOrderRequestFileApprovalLevel = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(12,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderRequestFileApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFileApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_daa6040aa65b55c2574e6a4e976766ce r) {
this = r;
}


public static bool operator == (RC_daa6040aa65b55c2574e6a4e976766ce a, RC_daa6040aa65b55c2574e6a4e976766ce b) {
if (a.ssENOrderRequestFileApprovalLevel != b.ssENOrderRequestFileApprovalLevel) return false;
return true;
}

public static bool operator != (RC_daa6040aa65b55c2574e6a4e976766ce a, RC_daa6040aa65b55c2574e6a4e976766ce b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_daa6040aa65b55c2574e6a4e976766ce)) return false;
return (this == (RC_daa6040aa65b55c2574e6a4e976766ce)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFileApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFileApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFileApprovalLevel.InternalRecursiveSave();
}


public RC_daa6040aa65b55c2574e6a4e976766ce Duplicate() {
RC_daa6040aa65b55c2574e6a4e976766ce t;
t.ssENOrderRequestFileApprovalLevel = (EN_80af67ecab8f43d464cc57955285a024EntityRecord)this.ssENOrderRequestFileApprovalLevel.Duplicate();
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
if (head == "orderrequestfileapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalLevel")) variable.Value = ssENOrderRequestFileApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFileApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFileApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderRequestFileApprovalLevel) {
return ssENOrderRequestFileApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFileApprovalLevel.Key.AsGuid) {
return ssENOrderRequestFileApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFileApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApprovalLevel));
}
} // RC_daa6040aa65b55c2574e6a4e976766ce
/// <summary>
/// RecordList type <code>OrderRequestFileApprovalLevelRecordList</code> that represents a record list
///  of <code>OrderRequestFileApprovalLevel</code>
/// </summary>
public partial class RL_1812a591b87097467375f4f1d26f72aa : GenericRecordList<RC_daa6040aa65b55c2574e6a4e976766ce>, IEnumerable, IEnumerator {

protected override RC_daa6040aa65b55c2574e6a4e976766ce GetElementDefaultValue() {
return new RC_daa6040aa65b55c2574e6a4e976766ce();
}

public T[] ToArray<T>(Func<RC_daa6040aa65b55c2574e6a4e976766ce, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1812a591b87097467375f4f1d26f72aa recordList, Func<RC_daa6040aa65b55c2574e6a4e976766ce, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1812a591b87097467375f4f1d26f72aa(RC_daa6040aa65b55c2574e6a4e976766ce[] array) {
  RL_1812a591b87097467375f4f1d26f72aa result = new RL_1812a591b87097467375f4f1d26f72aa();
result.InnerFromArray(array);
    return result;
}

public static RL_1812a591b87097467375f4f1d26f72aa ToList<T>(T[] array, Func <T, RC_daa6040aa65b55c2574e6a4e976766ce> converter) {
  RL_1812a591b87097467375f4f1d26f72aa result = new RL_1812a591b87097467375f4f1d26f72aa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1812a591b87097467375f4f1d26f72aa FromRestList<T>(RestList<T> restList, Func <T, RC_daa6040aa65b55c2574e6a4e976766ce> converter) {
  RL_1812a591b87097467375f4f1d26f72aa result = new RL_1812a591b87097467375f4f1d26f72aa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1812a591b87097467375f4f1d26f72aa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(12,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_daa6040aa65b55c2574e6a4e976766ce> NewList() {
return new RL_1812a591b87097467375f4f1d26f72aa();
}


} // RL_1812a591b87097467375f4f1d26f72aa
}

