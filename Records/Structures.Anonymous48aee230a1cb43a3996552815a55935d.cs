namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MOKuSMuho0OZZVKBWlWTXQ)
///  <code>RC_b944c231fcedefdc49a0fe2c36d0fb8a</code> that represent
/// s <code>OrderMainOrderDetailRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainOrderDetailRegionRecord
public partial struct RC_b944c231fcedefdc49a0fe2c36d0fb8a : ITypedRecord<RC_b944c231fcedefdc49a0fe2c36d0fb8a> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_b944c231fcedefdc49a0fe2c36d0fb8a() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(39,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENOrderDetail.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENOrderDetail.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
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
public void ReadIM(RC_b944c231fcedefdc49a0fe2c36d0fb8a r) {
this = r;
}


public static bool operator == (RC_b944c231fcedefdc49a0fe2c36d0fb8a a, RC_b944c231fcedefdc49a0fe2c36d0fb8a b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_b944c231fcedefdc49a0fe2c36d0fb8a a, RC_b944c231fcedefdc49a0fe2c36d0fb8a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b944c231fcedefdc49a0fe2c36d0fb8a)) return false;
return (this == (RC_b944c231fcedefdc49a0fe2c36d0fb8a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_b944c231fcedefdc49a0fe2c36d0fb8a Duplicate() {
RC_b944c231fcedefdc49a0fe2c36d0fb8a t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_b944c231fcedefdc49a0fe2c36d0fb8a
/// <summary>
/// RecordList type <code>OrderMainOrderDetailRegionRecordList</code> that represents a record list of
///  <code>OrderMain, OrderDetail, Region</code>
/// </summary>
public partial class RL_03c4be65764ae68c963db8500f2f1711 : GenericRecordList<RC_b944c231fcedefdc49a0fe2c36d0fb8a>, IEnumerable, IEnumerator {

protected override RC_b944c231fcedefdc49a0fe2c36d0fb8a GetElementDefaultValue() {
return new RC_b944c231fcedefdc49a0fe2c36d0fb8a();
}

public T[] ToArray<T>(Func<RC_b944c231fcedefdc49a0fe2c36d0fb8a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_03c4be65764ae68c963db8500f2f1711 recordList, Func<RC_b944c231fcedefdc49a0fe2c36d0fb8a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_03c4be65764ae68c963db8500f2f1711(RC_b944c231fcedefdc49a0fe2c36d0fb8a[] array) {
  RL_03c4be65764ae68c963db8500f2f1711 result = new RL_03c4be65764ae68c963db8500f2f1711();
result.InnerFromArray(array);
    return result;
}

public static RL_03c4be65764ae68c963db8500f2f1711 ToList<T>(T[] array, Func <T, RC_b944c231fcedefdc49a0fe2c36d0fb8a> converter) {
  RL_03c4be65764ae68c963db8500f2f1711 result = new RL_03c4be65764ae68c963db8500f2f1711();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_03c4be65764ae68c963db8500f2f1711 FromRestList<T>(RestList<T> restList, Func <T, RC_b944c231fcedefdc49a0fe2c36d0fb8a> converter) {
  RL_03c4be65764ae68c963db8500f2f1711 result = new RL_03c4be65764ae68c963db8500f2f1711();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_03c4be65764ae68c963db8500f2f1711() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(29,false);
def[1] = new BitArray(39,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b944c231fcedefdc49a0fe2c36d0fb8a> NewList() {
return new RL_03c4be65764ae68c963db8500f2f1711();
}


} // RL_03c4be65764ae68c963db8500f2f1711
}

