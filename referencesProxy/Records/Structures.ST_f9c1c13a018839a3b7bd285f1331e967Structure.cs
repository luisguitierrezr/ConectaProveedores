namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_SM_CECO_COSMOZReq (KPn08t9oG0ys+tk0gAaF3A)
///  <code>ST_f9c1c13a018839a3b7bd285f1331e967Structure</code> that represent
/// s <code>ZMXMIMMF_EM_SM_CECO_COSMOZReq</code> <p>Description: ZMXMIMMF_EM_SM_CECO_COSMOZReq</p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_CECO_COSMOZReq
public partial struct ST_f9c1c13a018839a3b7bd285f1331e967Structure : ITypedRecord<ST_f9c1c13a018839a3b7bd285f1331e967Structure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Q2qqyMatfEavgTRQyE5o7A");
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*hZWKpCQLd0+BWaK1QJDU9g");
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ZOw64GQZKUqg919qIJNcXQ");

public ST_f6501ee18e176493154e18d361367656Structure ssPI_HEADER;

public RL_299977c13e39cc1952c431fa77f88689 ssPI_ITEM_EM;

public RL_6c0520d55ae99ffd7c336b769881d282 ssPI_ITEM_SM;


public BitArray OptimizedAttributes;

public ST_f9c1c13a018839a3b7bd285f1331e967Structure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_f6501ee18e176493154e18d361367656Structure();
ssPI_ITEM_EM = new RL_299977c13e39cc1952c431fa77f88689();
ssPI_ITEM_SM = new RL_6c0520d55ae99ffd7c336b769881d282();
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
    ssPI_HEADER.OptimizedAttributes = value[0];
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
public void ReadIM(ST_f9c1c13a018839a3b7bd285f1331e967Structure r) {
this = r;
}


public static bool operator == (ST_f9c1c13a018839a3b7bd285f1331e967Structure a, ST_f9c1c13a018839a3b7bd285f1331e967Structure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM_EM != b.ssPI_ITEM_EM) return false;
if (a.ssPI_ITEM_SM != b.ssPI_ITEM_SM) return false;
return true;
}

public static bool operator != (ST_f9c1c13a018839a3b7bd285f1331e967Structure a, ST_f9c1c13a018839a3b7bd285f1331e967Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f9c1c13a018839a3b7bd285f1331e967Structure)) return false;
return (this == (ST_f9c1c13a018839a3b7bd285f1331e967Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_ITEM_EM.GetHashCode()
 ^ ssPI_ITEM_SM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssPI_ITEM_EM.RecursiveReset();
ssPI_ITEM_SM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssPI_ITEM_EM.InternalRecursiveSave();
ssPI_ITEM_SM.InternalRecursiveSave();
}


public ST_f9c1c13a018839a3b7bd285f1331e967Structure Duplicate() {
ST_f9c1c13a018839a3b7bd285f1331e967Structure t;
t.ssPI_HEADER = (ST_f6501ee18e176493154e18d361367656Structure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM_EM = (RL_299977c13e39cc1952c431fa77f88689)this.ssPI_ITEM_EM.Duplicate();
t.ssPI_ITEM_SM = (RL_6c0520d55ae99ffd7c336b769881d282)this.ssPI_ITEM_SM.Duplicate();
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
if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
} else if (head == "pi_item_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM")) variable.Value = ssPI_ITEM_EM; else variable.Optimized = true;
variable.SetFieldName("pi_item_em");
} else if (head == "pi_item_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM")) variable.Value = ssPI_ITEM_SM; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm");
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
if (key == IdPI_HEADER) {
return ssPI_HEADER;
}
if (key == IdPI_ITEM_EM) {
return ssPI_ITEM_EM;
}
if (key == IdPI_ITEM_SM) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_ITEM_EM.Key.AsGuid) {
return ssPI_ITEM_EM;
}
if (attributeKey == IdPI_ITEM_SM.Key.AsGuid) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_ITEM_EM = new RL_299977c13e39cc1952c431fa77f88689();
ssPI_ITEM_EM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_EM));
ssPI_ITEM_SM = new RL_6c0520d55ae99ffd7c336b769881d282();
ssPI_ITEM_SM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_SM));
}
} // ST_f9c1c13a018839a3b7bd285f1331e967Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_CECO_COSMOZReqList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_CECO_COSMOZReq</code>
/// </summary>
public partial class RL_e99c29df0b11f29b192f5fa59d1408a0 : GenericRecordList<ST_f9c1c13a018839a3b7bd285f1331e967Structure>, IEnumerable, IEnumerator {

protected override ST_f9c1c13a018839a3b7bd285f1331e967Structure GetElementDefaultValue() {
return new ST_f9c1c13a018839a3b7bd285f1331e967Structure();
}

public T[] ToArray<T>(Func<ST_f9c1c13a018839a3b7bd285f1331e967Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e99c29df0b11f29b192f5fa59d1408a0 recordList, Func<ST_f9c1c13a018839a3b7bd285f1331e967Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e99c29df0b11f29b192f5fa59d1408a0(ST_f9c1c13a018839a3b7bd285f1331e967Structure[] array) {
  RL_e99c29df0b11f29b192f5fa59d1408a0 result = new RL_e99c29df0b11f29b192f5fa59d1408a0();
result.InnerFromArray(array);
    return result;
}

public static RL_e99c29df0b11f29b192f5fa59d1408a0 ToList<T>(T[] array, Func <T, ST_f9c1c13a018839a3b7bd285f1331e967Structure> converter) {
  RL_e99c29df0b11f29b192f5fa59d1408a0 result = new RL_e99c29df0b11f29b192f5fa59d1408a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e99c29df0b11f29b192f5fa59d1408a0 FromRestList<T>(RestList<T> restList, Func <T, ST_f9c1c13a018839a3b7bd285f1331e967Structure> converter) {
  RL_e99c29df0b11f29b192f5fa59d1408a0 result = new RL_e99c29df0b11f29b192f5fa59d1408a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e99c29df0b11f29b192f5fa59d1408a0() : base() {
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
protected override OSList<ST_f9c1c13a018839a3b7bd285f1331e967Structure> NewList() {
return new RL_e99c29df0b11f29b192f5fa59d1408a0();
}


} // RL_e99c29df0b11f29b192f5fa59d1408a0
}

