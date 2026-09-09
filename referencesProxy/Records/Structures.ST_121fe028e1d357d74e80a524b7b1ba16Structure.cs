namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ItemEM_RM (ziK6hVDgs0O0GyszTTxZQQ)
///  <code>ST_121fe028e1d357d74e80a524b7b1ba16Structure</code> that represents <code>ItemEM_RM</code
/// > <p>Description: ItemEM_RM</p>
/// </summary>
// Name: ItemEM_RM
public partial struct ST_121fe028e1d357d74e80a524b7b1ba16Structure : ITypedRecord<ST_121fe028e1d357d74e80a524b7b1ba16Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*h0qN0YRf9UCLHU59+FdeRg");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_ADphIWLFESbLXYF1FCG0w");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*IIlExTa9v0ulPhBf5g2CyA");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*iOrI_OyEyE6mXPyxqJK45Q");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*24zrT9LY+Uy6PFEL0WjtFA");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*uCe0NBEWh0GwujSmum19LQ");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCANTIDAD_ENTRADA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_121fe028e1d357d74e80a524b7b1ba16Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "";
ssMATERIAL = "";
ssCANTIDAD_ENTRADA = "";
ssCENTRO = "";
ssALMACEN = "";
ssTEXTO_POSICION = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPOSICION_PEDIDO = r.ReadText(index++, "ItemEM_RM.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "ItemEM_RM.MATERIAL", "");
ssCANTIDAD_ENTRADA = r.ReadText(index++, "ItemEM_RM.CANTIDAD_ENTRADA", "");
ssCENTRO = r.ReadText(index++, "ItemEM_RM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "ItemEM_RM.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "ItemEM_RM.TEXTO_POSICION", "");
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
public void ReadIM(ST_121fe028e1d357d74e80a524b7b1ba16Structure r) {
this = r;
}


public static bool operator == (ST_121fe028e1d357d74e80a524b7b1ba16Structure a, ST_121fe028e1d357d74e80a524b7b1ba16Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_121fe028e1d357d74e80a524b7b1ba16Structure a, ST_121fe028e1d357d74e80a524b7b1ba16Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_121fe028e1d357d74e80a524b7b1ba16Structure)) return false;
return (this == (ST_121fe028e1d357d74e80a524b7b1ba16Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_121fe028e1d357d74e80a524b7b1ba16Structure Duplicate() {
ST_121fe028e1d357d74e80a524b7b1ba16Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_ENTRADA = (string) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_121fe028e1d357d74e80a524b7b1ba16Structure
/// <summary>
/// RecordList type <code>ItemEM_RMList</code> that represents a record list of <code>ItemEM_RM</code>
/// </summary>
public partial class RL_14f7fedf363c5e2bd9b617b5d8baba14 : GenericRecordList<ST_121fe028e1d357d74e80a524b7b1ba16Structure>, IEnumerable, IEnumerator {

protected override ST_121fe028e1d357d74e80a524b7b1ba16Structure GetElementDefaultValue() {
return new ST_121fe028e1d357d74e80a524b7b1ba16Structure();
}

public T[] ToArray<T>(Func<ST_121fe028e1d357d74e80a524b7b1ba16Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_14f7fedf363c5e2bd9b617b5d8baba14 recordList, Func<ST_121fe028e1d357d74e80a524b7b1ba16Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_14f7fedf363c5e2bd9b617b5d8baba14(ST_121fe028e1d357d74e80a524b7b1ba16Structure[] array) {
  RL_14f7fedf363c5e2bd9b617b5d8baba14 result = new RL_14f7fedf363c5e2bd9b617b5d8baba14();
result.InnerFromArray(array);
    return result;
}

public static RL_14f7fedf363c5e2bd9b617b5d8baba14 ToList<T>(T[] array, Func <T, ST_121fe028e1d357d74e80a524b7b1ba16Structure> converter) {
  RL_14f7fedf363c5e2bd9b617b5d8baba14 result = new RL_14f7fedf363c5e2bd9b617b5d8baba14();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_14f7fedf363c5e2bd9b617b5d8baba14 FromRestList<T>(RestList<T> restList, Func <T, ST_121fe028e1d357d74e80a524b7b1ba16Structure> converter) {
  RL_14f7fedf363c5e2bd9b617b5d8baba14 result = new RL_14f7fedf363c5e2bd9b617b5d8baba14();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_14f7fedf363c5e2bd9b617b5d8baba14() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_121fe028e1d357d74e80a524b7b1ba16Structure> NewList() {
return new RL_14f7fedf363c5e2bd9b617b5d8baba14();
}


} // RL_14f7fedf363c5e2bd9b617b5d8baba14
}

