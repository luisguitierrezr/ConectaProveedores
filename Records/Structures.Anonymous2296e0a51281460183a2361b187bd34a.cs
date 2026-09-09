namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (peCWIoESAUaDojYbGHvTSg)
///  <code>RC_f7c91773292f225022263e13d34e21c5</code> that represent
/// s <code>FolioApprovalFolioOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioOrderMainRecord
public partial struct RC_f7c91773292f225022263e13d34e21c5 : ITypedRecord<RC_f7c91773292f225022263e13d34e21c5> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_f7c91773292f225022263e13d34e21c5() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_f7c91773292f225022263e13d34e21c5 r) {
this = r;
}


public static bool operator == (RC_f7c91773292f225022263e13d34e21c5 a, RC_f7c91773292f225022263e13d34e21c5 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_f7c91773292f225022263e13d34e21c5 a, RC_f7c91773292f225022263e13d34e21c5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f7c91773292f225022263e13d34e21c5)) return false;
return (this == (RC_f7c91773292f225022263e13d34e21c5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_f7c91773292f225022263e13d34e21c5 Duplicate() {
RC_f7c91773292f225022263e13d34e21c5 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_f7c91773292f225022263e13d34e21c5
/// <summary>
/// RecordList type <code>FolioApprovalFolioOrderMainRecordList</code> that represents a record list of
///  <code>FolioApproval, Folio, OrderMain</code>
/// </summary>
public partial class RL_ecd1c5152b10fa2a937ada7598ead4ad : GenericRecordList<RC_f7c91773292f225022263e13d34e21c5>, IEnumerable, IEnumerator {

protected override RC_f7c91773292f225022263e13d34e21c5 GetElementDefaultValue() {
return new RC_f7c91773292f225022263e13d34e21c5();
}

public T[] ToArray<T>(Func<RC_f7c91773292f225022263e13d34e21c5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ecd1c5152b10fa2a937ada7598ead4ad recordList, Func<RC_f7c91773292f225022263e13d34e21c5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ecd1c5152b10fa2a937ada7598ead4ad(RC_f7c91773292f225022263e13d34e21c5[] array) {
  RL_ecd1c5152b10fa2a937ada7598ead4ad result = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
result.InnerFromArray(array);
    return result;
}

public static RL_ecd1c5152b10fa2a937ada7598ead4ad ToList<T>(T[] array, Func <T, RC_f7c91773292f225022263e13d34e21c5> converter) {
  RL_ecd1c5152b10fa2a937ada7598ead4ad result = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ecd1c5152b10fa2a937ada7598ead4ad FromRestList<T>(RestList<T> restList, Func <T, RC_f7c91773292f225022263e13d34e21c5> converter) {
  RL_ecd1c5152b10fa2a937ada7598ead4ad result = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ecd1c5152b10fa2a937ada7598ead4ad() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f7c91773292f225022263e13d34e21c5> NewList() {
return new RL_ecd1c5152b10fa2a937ada7598ead4ad();
}


} // RL_ecd1c5152b10fa2a937ada7598ead4ad
}

